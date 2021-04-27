namespace emgu_test
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
            this.components = new System.ComponentModel.Container();
            this.UI_cmd_LoadImage = new System.Windows.Forms.Button();
            this.ibOrigin = new Emgu.CV.UI.ImageBox();
            this.ibBig = new Emgu.CV.UI.ImageBox();
            this.UI_lst_MethodsList = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UI_lst_SelectedMethods = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ibOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibBig)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_cmd_LoadImage
            // 
            this.UI_cmd_LoadImage.Location = new System.Drawing.Point(12, 13);
            this.UI_cmd_LoadImage.Name = "UI_cmd_LoadImage";
            this.UI_cmd_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.UI_cmd_LoadImage.TabIndex = 0;
            this.UI_cmd_LoadImage.Text = "Load Image";
            this.UI_cmd_LoadImage.UseVisualStyleBackColor = true;
            this.UI_cmd_LoadImage.Click += new System.EventHandler(this.UI_cmd_LoadImage_Click);
            // 
            // ibOrigin
            // 
            this.ibOrigin.Location = new System.Drawing.Point(102, 13);
            this.ibOrigin.Name = "ibOrigin";
            this.ibOrigin.Size = new System.Drawing.Size(200, 200);
            this.ibOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibOrigin.TabIndex = 2;
            this.ibOrigin.TabStop = false;
            // 
            // ibBig
            // 
            this.ibBig.Location = new System.Drawing.Point(431, 12);
            this.ibBig.Name = "ibBig";
            this.ibBig.Size = new System.Drawing.Size(550, 550);
            this.ibBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibBig.TabIndex = 2;
            this.ibBig.TabStop = false;
            // 
            // UI_lst_MethodsList
            // 
            this.UI_lst_MethodsList.AllowDrop = true;
            this.UI_lst_MethodsList.AutoScroll = true;
            this.UI_lst_MethodsList.BackColor = System.Drawing.SystemColors.Window;
            this.UI_lst_MethodsList.Location = new System.Drawing.Point(25, 240);
            this.UI_lst_MethodsList.Name = "UI_lst_MethodsList";
            this.UI_lst_MethodsList.Size = new System.Drawing.Size(171, 700);
            this.UI_lst_MethodsList.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Methods List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Apply List";
            // 
            // UI_lst_SelectedMethods
            // 
            this.UI_lst_SelectedMethods.AutoScroll = true;
            this.UI_lst_SelectedMethods.BackColor = System.Drawing.SystemColors.Window;
            this.UI_lst_SelectedMethods.Location = new System.Drawing.Point(221, 240);
            this.UI_lst_SelectedMethods.Name = "UI_lst_SelectedMethods";
            this.UI_lst_SelectedMethods.Size = new System.Drawing.Size(171, 700);
            this.UI_lst_SelectedMethods.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1003, 979);
            this.Controls.Add(this.UI_lst_SelectedMethods);
            this.Controls.Add(this.UI_lst_MethodsList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ibOrigin);
            this.Controls.Add(this.UI_cmd_LoadImage);
            this.Controls.Add(this.ibBig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_cmd_LoadImage;
        private Emgu.CV.UI.ImageBox ibOrigin;
        private Emgu.CV.UI.ImageBox ibBig;
        private System.Windows.Forms.Panel UI_lst_MethodsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel UI_lst_SelectedMethods;
    }
}

