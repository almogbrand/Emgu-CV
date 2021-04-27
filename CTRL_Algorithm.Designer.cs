namespace emgu_test
{
    partial class CTRL_Algorithm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UI_pnl_Soble = new System.Windows.Forms.Panel();
            this.UI_pnl_Flip = new System.Windows.Forms.Panel();
            this.rbtnHorizontal = new System.Windows.Forms.RadioButton();
            this.rbtnVertical = new System.Windows.Forms.RadioButton();
            this.UI_pnl_Threshold = new System.Windows.Forms.Panel();
            this.txtThr = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.UI_pnl_Canny = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCannyThr2 = new System.Windows.Forms.TextBox();
            this.txtCannyThr1 = new System.Windows.Forms.TextBox();
            this.UI_pnl_Greyscale = new System.Windows.Forms.Panel();
            this.UI_pnl_Rotation = new System.Windows.Forms.Panel();
            this.rbtnLeft = new System.Windows.Forms.RadioButton();
            this.rbtnRight = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.UI_pnl_Flip.SuspendLayout();
            this.UI_pnl_Threshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.UI_pnl_Canny.SuspendLayout();
            this.UI_pnl_Rotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.UI_pnl_Soble);
            this.groupBox1.Controls.Add(this.UI_pnl_Flip);
            this.groupBox1.Controls.Add(this.UI_pnl_Threshold);
            this.groupBox1.Controls.Add(this.UI_pnl_Canny);
            this.groupBox1.Controls.Add(this.UI_pnl_Greyscale);
            this.groupBox1.Controls.Add(this.UI_pnl_Rotation);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 541);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(3, 397);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(503, 131);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 10);
            this.panel1.TabIndex = 31;
            // 
            // UI_pnl_Soble
            // 
            this.UI_pnl_Soble.Location = new System.Drawing.Point(353, 205);
            this.UI_pnl_Soble.Name = "UI_pnl_Soble";
            this.UI_pnl_Soble.Size = new System.Drawing.Size(149, 81);
            this.UI_pnl_Soble.TabIndex = 29;
            this.UI_pnl_Soble.Visible = false;
            // 
            // UI_pnl_Flip
            // 
            this.UI_pnl_Flip.Controls.Add(this.rbtnHorizontal);
            this.UI_pnl_Flip.Controls.Add(this.rbtnVertical);
            this.UI_pnl_Flip.Location = new System.Drawing.Point(353, 292);
            this.UI_pnl_Flip.Name = "UI_pnl_Flip";
            this.UI_pnl_Flip.Size = new System.Drawing.Size(149, 81);
            this.UI_pnl_Flip.TabIndex = 26;
            this.UI_pnl_Flip.Visible = false;
            // 
            // rbtnHorizontal
            // 
            this.rbtnHorizontal.AutoSize = true;
            this.rbtnHorizontal.Location = new System.Drawing.Point(40, 45);
            this.rbtnHorizontal.Name = "rbtnHorizontal";
            this.rbtnHorizontal.Size = new System.Drawing.Size(72, 17);
            this.rbtnHorizontal.TabIndex = 25;
            this.rbtnHorizontal.Text = "Horizontal";
            this.rbtnHorizontal.UseVisualStyleBackColor = true;
            // 
            // rbtnVertical
            // 
            this.rbtnVertical.AutoSize = true;
            this.rbtnVertical.Checked = true;
            this.rbtnVertical.Location = new System.Drawing.Point(40, 22);
            this.rbtnVertical.Name = "rbtnVertical";
            this.rbtnVertical.Size = new System.Drawing.Size(60, 17);
            this.rbtnVertical.TabIndex = 24;
            this.rbtnVertical.TabStop = true;
            this.rbtnVertical.Text = "Vertical";
            this.rbtnVertical.UseVisualStyleBackColor = true;
            // 
            // UI_pnl_Threshold
            // 
            this.UI_pnl_Threshold.BackColor = System.Drawing.Color.Transparent;
            this.UI_pnl_Threshold.Controls.Add(this.txtThr);
            this.UI_pnl_Threshold.Controls.Add(this.trackBar1);
            this.UI_pnl_Threshold.Location = new System.Drawing.Point(198, 205);
            this.UI_pnl_Threshold.Name = "UI_pnl_Threshold";
            this.UI_pnl_Threshold.Size = new System.Drawing.Size(149, 81);
            this.UI_pnl_Threshold.TabIndex = 30;
            this.UI_pnl_Threshold.Visible = false;
            // 
            // txtThr
            // 
            this.txtThr.Location = new System.Drawing.Point(62, 10);
            this.txtThr.Name = "txtThr";
            this.txtThr.Size = new System.Drawing.Size(22, 20);
            this.txtThr.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(36, 33);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(73, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // UI_pnl_Canny
            // 
            this.UI_pnl_Canny.Controls.Add(this.label2);
            this.UI_pnl_Canny.Controls.Add(this.label1);
            this.UI_pnl_Canny.Controls.Add(this.txtCannyThr2);
            this.UI_pnl_Canny.Controls.Add(this.txtCannyThr1);
            this.UI_pnl_Canny.Location = new System.Drawing.Point(353, 118);
            this.UI_pnl_Canny.Name = "UI_pnl_Canny";
            this.UI_pnl_Canny.Size = new System.Drawing.Size(149, 81);
            this.UI_pnl_Canny.TabIndex = 27;
            this.UI_pnl_Canny.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(79, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Threshold 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Threshold 1";
            // 
            // txtCannyThr2
            // 
            this.txtCannyThr2.Enabled = false;
            this.txtCannyThr2.Location = new System.Drawing.Point(86, 19);
            this.txtCannyThr2.Name = "txtCannyThr2";
            this.txtCannyThr2.Size = new System.Drawing.Size(42, 20);
            this.txtCannyThr2.TabIndex = 25;
            this.txtCannyThr2.Text = "150";
            // 
            // txtCannyThr1
            // 
            this.txtCannyThr1.Enabled = false;
            this.txtCannyThr1.Location = new System.Drawing.Point(18, 19);
            this.txtCannyThr1.Name = "txtCannyThr1";
            this.txtCannyThr1.Size = new System.Drawing.Size(42, 20);
            this.txtCannyThr1.TabIndex = 24;
            this.txtCannyThr1.Text = "50";
            // 
            // UI_pnl_Greyscale
            // 
            this.UI_pnl_Greyscale.Location = new System.Drawing.Point(353, 31);
            this.UI_pnl_Greyscale.Name = "UI_pnl_Greyscale";
            this.UI_pnl_Greyscale.Size = new System.Drawing.Size(149, 81);
            this.UI_pnl_Greyscale.TabIndex = 28;
            this.UI_pnl_Greyscale.Visible = false;
            // 
            // UI_pnl_Rotation
            // 
            this.UI_pnl_Rotation.BackColor = System.Drawing.Color.Transparent;
            this.UI_pnl_Rotation.Controls.Add(this.rbtnLeft);
            this.UI_pnl_Rotation.Controls.Add(this.rbtnRight);
            this.UI_pnl_Rotation.Location = new System.Drawing.Point(198, 292);
            this.UI_pnl_Rotation.Name = "UI_pnl_Rotation";
            this.UI_pnl_Rotation.Size = new System.Drawing.Size(149, 81);
            this.UI_pnl_Rotation.TabIndex = 27;
            this.UI_pnl_Rotation.Visible = false;
            // 
            // rbtnLeft
            // 
            this.rbtnLeft.AutoSize = true;
            this.rbtnLeft.Location = new System.Drawing.Point(40, 45);
            this.rbtnLeft.Name = "rbtnLeft";
            this.rbtnLeft.Size = new System.Drawing.Size(43, 17);
            this.rbtnLeft.TabIndex = 25;
            this.rbtnLeft.Text = "Left";
            this.rbtnLeft.UseVisualStyleBackColor = true;
            // 
            // rbtnRight
            // 
            this.rbtnRight.AutoSize = true;
            this.rbtnRight.Checked = true;
            this.rbtnRight.Location = new System.Drawing.Point(40, 22);
            this.rbtnRight.Name = "rbtnRight";
            this.rbtnRight.Size = new System.Drawing.Size(50, 17);
            this.rbtnRight.TabIndex = 24;
            this.rbtnRight.TabStop = true;
            this.rbtnRight.Text = "Right";
            this.rbtnRight.UseVisualStyleBackColor = true;
            // 
            // CTRL_Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CTRL_Algorithm";
            this.Size = new System.Drawing.Size(554, 580);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.UI_pnl_Flip.ResumeLayout(false);
            this.UI_pnl_Flip.PerformLayout();
            this.UI_pnl_Threshold.ResumeLayout(false);
            this.UI_pnl_Threshold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.UI_pnl_Canny.ResumeLayout(false);
            this.UI_pnl_Canny.PerformLayout();
            this.UI_pnl_Rotation.ResumeLayout(false);
            this.UI_pnl_Rotation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel UI_pnl_Flip;
        private System.Windows.Forms.Panel UI_pnl_Canny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCannyThr2;
        private System.Windows.Forms.TextBox txtCannyThr1;
        private System.Windows.Forms.Panel UI_pnl_Greyscale;
        private System.Windows.Forms.Panel UI_pnl_Rotation;
        private System.Windows.Forms.RadioButton rbtnLeft;
        private System.Windows.Forms.RadioButton rbtnRight;
        private System.Windows.Forms.RadioButton rbtnHorizontal;
        private System.Windows.Forms.RadioButton rbtnVertical;
        private System.Windows.Forms.Panel UI_pnl_Soble;
        private System.Windows.Forms.Panel UI_pnl_Threshold;
        private System.Windows.Forms.TextBox txtThr;
        private System.Windows.Forms.TrackBar trackBar1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
