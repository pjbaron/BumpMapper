namespace BumpMapper
{
    partial class Form1
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox_src = new System.Windows.Forms.PictureBox();
            this.pictureBox_bump = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_depth = new System.Windows.Forms.PictureBox();
            this.buttonLoadBump = new System.Windows.Forms.Button();
            this.trackBarPower = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bump)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBarRadius);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarPower);
            this.panel1.Controls.Add(this.buttonLoadBump);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(234, 37);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit Bumps";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(333, 8);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(93, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create Bumps";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(234, 66);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save Bump...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load Texture...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox_src);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_bump);
            this.splitContainer1.Size = new System.Drawing.Size(483, 242);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox_src
            // 
            this.pictureBox_src.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_src.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_src.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_src.Name = "pictureBox_src";
            this.pictureBox_src.Size = new System.Drawing.Size(230, 242);
            this.pictureBox_src.TabIndex = 0;
            this.pictureBox_src.TabStop = false;
            // 
            // pictureBox_bump
            // 
            this.pictureBox_bump.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox_bump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_bump.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_bump.Name = "pictureBox_bump";
            this.pictureBox_bump.Size = new System.Drawing.Size(249, 242);
            this.pictureBox_bump.TabIndex = 0;
            this.pictureBox_bump.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.pictureBox_depth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(483, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 242);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox_depth
            // 
            this.pictureBox_depth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_depth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_depth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_depth.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_depth.Name = "pictureBox_depth";
            this.pictureBox_depth.Size = new System.Drawing.Size(238, 242);
            this.pictureBox_depth.TabIndex = 0;
            this.pictureBox_depth.TabStop = false;
            this.pictureBox_depth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_depth_MouseMove);
            // 
            // buttonLoadBump
            // 
            this.buttonLoadBump.Location = new System.Drawing.Point(234, 8);
            this.buttonLoadBump.Name = "buttonLoadBump";
            this.buttonLoadBump.Size = new System.Drawing.Size(93, 23);
            this.buttonLoadBump.TabIndex = 5;
            this.buttonLoadBump.Text = "Load Bump...";
            this.buttonLoadBump.UseVisualStyleBackColor = true;
            this.buttonLoadBump.Click += new System.EventHandler(this.buttonLoadBump_Click);
            // 
            // trackBarPower
            // 
            this.trackBarPower.Location = new System.Drawing.Point(570, 8);
            this.trackBarPower.Maximum = 16;
            this.trackBarPower.Name = "trackBarPower";
            this.trackBarPower.Size = new System.Drawing.Size(139, 45);
            this.trackBarPower.TabIndex = 6;
            this.trackBarPower.TickFrequency = 4;
            this.trackBarPower.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPower.Scroll += new System.EventHandler(this.trackBarPower_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Light Power:";
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(570, 49);
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(139, 45);
            this.trackBarRadius.TabIndex = 8;
            this.trackBarRadius.TickFrequency = 2;
            this.trackBarRadius.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarRadius.Scroll += new System.EventHandler(this.trackBarRadius_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Light Radius:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 342);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bump)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox_src;
        private System.Windows.Forms.PictureBox pictureBox_bump;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_depth;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonLoadBump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarRadius;
    }
}

