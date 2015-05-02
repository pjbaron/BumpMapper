using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace BumpMapper
{
    public partial class Form1 : Form
    {
        private Image textureImage;

        private Image filterImage;
        private BitmapData filterSource;
        private byte[] filterPixels;
        private Random rnd;
        private int lightPower = 6;
        private double lightRadius = 0.3;



        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            trackBarPower.Value = lightPower;
            trackBarRadius.Value = (int)(lightRadius * 10.0 + 0.5);
        }



        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult r = fd.ShowDialog();
            if (r == DialogResult.OK)
            {
                string file = fd.FileName;
                textureImage = Image.FromFile(file);
                pictureBox_src.Image = textureImage;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            DialogResult r = fd.ShowDialog();
            if (r == DialogResult.OK)
            {
                string file = fd.FileName;
                filterImage.Save(file);
            }
        }

        private void buttonLoadBump_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult r = fd.ShowDialog();
            if (r == DialogResult.OK)
            {
                string file = fd.FileName;
                filterImage = Image.FromFile(file);
                GetFilterPixels();
                pictureBox_bump.Image = filterImage;
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textureImage != null)
            {
                CreateBumps(textureImage);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void trackBarPower_Scroll(object sender, EventArgs e)
        {
            lightPower = trackBarPower.Value;
        }

        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            lightRadius = (double)trackBarRadius.Value * 0.1;
        }



        private void CreateBumps(Image textureImage)
        {
            Bitmap greyImage = MakeGrayscale((Bitmap)textureImage);
            filterImage = (Image)MakeFilter(greyImage);
            pictureBox_bump.Image = filterImage;
            GetFilterPixels();
            pictureBox_depth.BackgroundImage = (Image)CreateTiles(textureImage, pictureBox_depth.Width, pictureBox_depth.Height);
        }

        private void GetFilterPixels()
        {
            // get the filter pixels for rapid access
            filterSource = ((Bitmap)filterImage).LockBits(new Rectangle(0, 0, filterImage.Width, filterImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            filterPixels = new byte[filterSource.Stride * filterImage.Height];
            Marshal.Copy(filterSource.Scan0, filterPixels, 0, filterPixels.Length);
            ((Bitmap)filterImage).UnlockBits(filterSource);
        }

        private Bitmap CreateTiles(Image tile, int width, int height)
        {
            Bitmap img = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)img);

            for (var y = 0; y < height; y += tile.Height)
                for (var x = 0; x < width; x += tile.Width)
                    g.DrawImage(tile, x, y);
            g.Dispose();
            return img;
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private Bitmap MakeFilter(Bitmap src)
        {
            Bitmap newBitmap = new Bitmap(src.Width, src.Height);
            Graphics grfx = Graphics.FromImage(src);

            // get the pixels
            BitmapData sourceData = src.LockBits(new Rectangle (0, 0, src.Width, src.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb); 
            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height]; 
            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length); 
            src.UnlockBits(sourceData);

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];
            for (int c = 0; c < resultBuffer.Length; c++)
                resultBuffer[c] = 0;
            
            int[,] filterx = new int[3, 3] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            int[,] filtery = new int[3, 3] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            int[][,] filters = new int[2][,] { filterx, filtery };

            int filterWidth = 3; 
            int filterHeight = 3;
            int filterHalfWide = (filterWidth - 1) / 2;
            int filterHalfHigh = (filterHeight - 1) / 2;

            System.Drawing.Color[] colors = { Color.FromArgb(255, 0, 0), Color.FromArgb(0, 255, 0) };

            for (int i = 0; i < filters.Length; i++)
            {
                int[,] filter = filters[i];
                int rmul = (int)(colors[i].R / 255);
                int gmul = (int)(colors[i].G / 255);
                int srcPos = 0;

                // for every pixel of the image
                for (int y = filterHalfHigh; y < src.Height - filterHalfHigh; y++)
                {
                    for (int x = filterHalfWide; x < src.Width - filterHalfWide; x++)
                    {
                        int r = 128 * rmul, g = 128 * gmul, b = 0;
                        srcPos = x * 4 + y * sourceData.Stride;

                        // for every value in the filter
                        for (int fy = -filterHalfHigh; fy <= filterHalfHigh; fy++)
                        {
                            for (int fx = -filterHalfWide; fx <= filterHalfWide; fx++)
                            {
                                int f = filter[fy + filterHalfHigh, fx + filterHalfWide];
                                int off = srcPos + fx * 4 + fy * sourceData.Stride;
                                r += pixelBuffer[off + 2] * f * rmul;
                                g += pixelBuffer[off + 1] * f * gmul;
                            }
                        }

                        resultBuffer[srcPos + 2] += (byte)(Clamp(r, 0, 255));
                        resultBuffer[srcPos + 1] += (byte)(Clamp(g, 0, 255));
                        resultBuffer[srcPos + 0] += (byte)(Clamp(b, 0, 255));
                        resultBuffer[srcPos + 3] = 255;
                    }
                }
            }

            // create bitmap to hold results
            Bitmap resultBitmap = new Bitmap(src.Width, src.Height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);
            return resultBitmap; 
        }


        private Bitmap MakeGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][] 
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        private void pictureBox_depth_MouseMove(object sender, MouseEventArgs e)
        {
            if (textureImage != null && filterImage != null)
            {
                pictureBox_depth.BackgroundImage = showLighting(e.Location.X, e.Location.Y);
                // force the picture to refresh immediately
                // there's probably another mousemove event ready to jump in already and that makes the visual update steppy
                pictureBox_depth.Refresh();
                System.Threading.Thread.Sleep(0);
            }
        }

        private Bitmap showLighting(int mx, int my)
        {
            Bitmap src = CreateTiles(textureImage, pictureBox_depth.Width, pictureBox_depth.Height);

            // get the pixels
            BitmapData sourceData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            src.UnlockBits(sourceData);

            // create the output pixel buffer
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            int srcPos = 0;

            // for every pixel of the image
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    srcPos = x * 4 + y * sourceData.Stride;

                    double r = (double)pixelBuffer[srcPos + 2] / 255.0;
                    double g = (double)pixelBuffer[srcPos + 1] / 255.0;
                    double b = (double)pixelBuffer[srcPos + 0] / 255.0;

                    double red, green, blue;

                    ApplyLighting(
                        (double)x / (double)pictureBox_depth.Width, (double)y / (double)pictureBox_depth.Height,
                        (double)mx / (double)pictureBox_depth.Width, (double)my / (double)pictureBox_depth.Height,
                        out red, out green, out blue);

                    resultBuffer[srcPos + 2] = (byte)(Clamp((int)((r + red) * 255.0), 0, 255));
                    resultBuffer[srcPos + 1] = (byte)(Clamp((int)((g + green) * 255.0), 0, 255));
                    resultBuffer[srcPos + 0] = (byte)(Clamp((int)((b + blue) * 255.0), 0, 255));
                    resultBuffer[srcPos + 3] = 255;
                }
            }

            // create bitmap to hold results
            Bitmap resultBitmap = new Bitmap(src.Width, src.Height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }


        // emulate the shader
        void ApplyLighting(double px, double py, double mx, double my, out double r, out double g, out double b)
        {
            Color brightness = Color.FromArgb(lightPower, lightPower, lightPower);

            // make the light edges flicker a little to create a softer blur effect
            //double dx = (mx - px) + (rnd.NextDouble() - 0.5) * 0.01;
            //double dy = (my - py) + (rnd.NextDouble() - 0.5) * 0.01;
            // hard stationary light edges
            double dx = (mx - px);
            double dy = (my - py);

            double d = Math.Sqrt(dx * dx + dy * dy) / lightRadius;
            if (d >= 1.0)
            {
                r = g = b = 0.0;
                return;
            }

            double od = d * 3.0 + 0.3;
            double bright = GetBright(px, py, dx, dy, 1.0 - d);
            double mul = (0.09 / (od * od)) * bright;
            r = (double)brightness.R * mul;
            g = (double)brightness.G * mul;
            b = (double)brightness.B * mul;
        }


        double GetBright(double px, double py, double dx, double dy, double id)
        {
            double ret = 0.0;

            int sx = (int)(px * pictureBox_depth.Width) % filterImage.Width;
            int sy = (int)(py * pictureBox_depth.Height) % filterImage.Height;

            int srcPos = sx * 4 + sy * filterSource.Stride;
            double r = ((double)filterPixels[srcPos + 2] / 255.0) - 0.5;
            double g = ((double)filterPixels[srcPos + 1] / 255.0) - 0.5;

            if (Math.Abs(r) <= 0.1)
                ret += 0.5 * id;
            else
            {
                if (dx < 0.0 && r < 0.0) ret += Math.Abs(r) * id;
                if (dx > 0.0 && r > 0.0) ret += Math.Abs(r) * id;
            }

            if (Math.Abs(g) <= 0.1)
                ret += 0.5 * id;
            else
            {
                if (dy > 0.0 && g < 0.0) ret += Math.Abs(g) * id;
                if (dy < 0.0 && g > 0.0) ret += Math.Abs(g) * id;
            }

            return ret;
        }


    }
}
