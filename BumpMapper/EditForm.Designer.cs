namespace BumpMapper
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarScaleY = new System.Windows.Forms.TrackBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.trackBarTilt = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3d = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTilt)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3d)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.trackBarScaleY);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonInvert);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarHeight);
            this.panel1.Controls.Add(this.trackBarTilt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 100);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(471, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Scale Y";
            // 
            // trackBarScaleY
            // 
            this.trackBarScaleY.Location = new System.Drawing.Point(479, 11);
            this.trackBarScaleY.Maximum = 100;
            this.trackBarScaleY.Name = "trackBarScaleY";
            this.trackBarScaleY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarScaleY.Size = new System.Drawing.Size(45, 88);
            this.trackBarScaleY.TabIndex = 8;
            this.trackBarScaleY.TickFrequency = 10;
            this.trackBarScaleY.ValueChanged += new System.EventHandler(this.trackBarScaleY_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(530, 70);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Image Edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display Settings";
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(530, 3);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(75, 23);
            this.buttonInvert.TabIndex = 3;
            this.buttonInvert.Text = "Invert";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tilt";
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.Location = new System.Drawing.Point(40, 11);
            this.trackBarHeight.Maximum = 100;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHeight.Size = new System.Drawing.Size(45, 88);
            this.trackBarHeight.TabIndex = 1;
            this.trackBarHeight.TickFrequency = 10;
            this.trackBarHeight.ValueChanged += new System.EventHandler(this.trackBarHeight_ValueChanged);
            // 
            // trackBarTilt
            // 
            this.trackBarTilt.Location = new System.Drawing.Point(-1, 11);
            this.trackBarTilt.Maximum = 100;
            this.trackBarTilt.Name = "trackBarTilt";
            this.trackBarTilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTilt.Size = new System.Drawing.Size(45, 88);
            this.trackBarTilt.TabIndex = 0;
            this.trackBarTilt.TickFrequency = 10;
            this.trackBarTilt.Value = 50;
            this.trackBarTilt.ValueChanged += new System.EventHandler(this.trackBarTilt_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3d);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 474);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3d
            // 
            this.pictureBox3d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3d.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3d.Name = "pictureBox3d";
            this.pictureBox3d.Size = new System.Drawing.Size(610, 474);
            this.pictureBox3d.TabIndex = 0;
            this.pictureBox3d.TabStop = false;
            this.pictureBox3d.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3d_Paint);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTilt)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3d;
        private System.Windows.Forms.TrackBar trackBarTilt;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarScaleY;
    }
}