using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BumpMapper
{
    public partial class EditForm : Form
    {
        private Bitmap srcImage = null;
        private int[,] heights;
        private double tilt = 0.5;
        private double heightScale = 1.0;

        // TODO: hand edit of height map
        // TODO: permit a tile sheet to be edited one tile at a time instead of all at once
        // TODO: implement contrast enhance (adjust slope magnitude)
        // TODO: preview of lighting added to edit window for immediate feedback.
        // TODO: separate invert into X and Y components in case of hand created image which is incorrect


        public EditForm()
        {
            InitializeComponent();
        }


        public void SetImage(Bitmap image)
        {
            if (image != null)
            {
                srcImage = image;
                heights = new int[srcImage.Width, srcImage.Height];
                FillEdges(ref srcImage);
                CalculateHeights(srcImage);
            }
        }


        private void FillEdges(ref Bitmap image)
        {
            // if the edges are transparent, duplicate a neighbour into them
            if (image.GetPixel(0, 0).A == 0)
            {
                Color col;
                for (int y = 1; y < image.Height - 1; y++)
                {
                    col = image.GetPixel(1, y);
                    image.SetPixel(0, y, col);
                    col = image.GetPixel(image.Width - 2, y);
                    image.SetPixel(image.Width - 1, y, col);
                }
                for (int x = 0; x < image.Width; x++)
                {
                    col = image.GetPixel(x, 1);
                    image.SetPixel(x, 0, col);
                    col = image.GetPixel(x, image.Height - 2);
                    image.SetPixel(x, image.Height - 1, col);
                }
                col = image.GetPixel(1, 1);
                image.SetPixel(0, 0, col);
                col = image.GetPixel(1, image.Height - 2);
                image.SetPixel(0, image.Height - 1, col);

                col = image.GetPixel(image.Width - 2, 1);
                image.SetPixel(image.Width - 1, 0, col);
                col = image.GetPixel(image.Width - 2, image.Height - 2);
                image.SetPixel(image.Width - 1, image.Height - 1, col);
            }
        }


        private void CalculateHeights(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color col = image.GetPixel(x, y);
                    int horiz = 0;
                    if (x > 0) horiz = -(col.R - 128) / 64 + heights[x - 1, y];
                    int vert = 0;
                    if (y > 0) vert = -(col.G - 128) / 64 + heights[x, y - 1];
                    if (Math.Abs(horiz) > Math.Abs(vert))
                        heights[x, y] = horiz;
                    else
                        heights[x, y] = vert;
                }
            }
        }


        private void pictureBox3d_Paint(object sender, PaintEventArgs e)
        {
            if (srcImage == null) return;

            tilt = (double)(trackBarTilt.Value / 200.0) + 0.5;
            heightScale = (double)(trackBarHeight.Value / 10.0) + 1.0;

            Graphics grfx = e.Graphics;

            double scalex = pictureBox3d.Width / srcImage.Width * 0.75;
            double scaley = pictureBox3d.Height / srcImage.Height * tilt;
            double midx = pictureBox3d.Width * 0.5;
            double midy = pictureBox3d.Height * 0.5;
            double offx = -srcImage.Width * scalex * 0.75 * 0.5;
            double offy = -srcImage.Height * scaley * 0.5;

            for (int y = 0; y < srcImage.Height; y++)
                for (int x = 0; x < srcImage.Width; x++)
                {
                    double sx = (offx + midx + (double)x * scalex - (double)y * scaley * 0.5);
                    double sy = (offy + midy + (double)y * scaley);

                    sy -= (double)heights[x, y] * heightScale;

                    Point[] shape = new Point[4];
                    shape[0] = new Point((int)(sx + scaley * 0.5), (int)sy);
                    shape[1] = new Point((int)(sx + scalex + scaley * 0.5), (int)sy);
                    shape[2] = new Point((int)(sx + scalex), (int)(sy + scaley));
                    shape[3] = new Point((int)(sx), (int)(sy + scaley));

                    Color col = srcImage.GetPixel(x, y);
                    grfx.FillPolygon(new SolidBrush(col), shape);
                    //grfx.DrawPolygon(new Pen(Color.Black), shape);
                }
        }

        private void trackBarTilt_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBarHeight_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < srcImage.Height; y++)
                for (int x = 0; x < srcImage.Width; x++)
                {
                    Color col = srcImage.GetPixel(x, y);
                    srcImage.SetPixel(x, y, Color.FromArgb(col.A, 255 - col.R, 255 - col.G, col.B));
                }
            CalculateHeights(srcImage);
            Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            DialogResult r = fd.ShowDialog();
            if (r == DialogResult.OK)
            {
                string file = fd.FileName;
                srcImage.Save(file);
            }
        }

        private void trackBarScaleY_ValueChanged(object sender, EventArgs e)
        {
            // find maximum contrast in vertical direction
            // if it's less than the full range, scale all colour Green components using this Value
        }

    }
}
