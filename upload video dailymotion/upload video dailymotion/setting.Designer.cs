namespace upload_video_dailymotion
{
    partial class setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dir_firefox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dir_save_video = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dir Location FireFox";
            // 
            // txt_dir_firefox
            // 
            this.txt_dir_firefox.Location = new System.Drawing.Point(15, 25);
            this.txt_dir_firefox.Name = "txt_dir_firefox";
            this.txt_dir_firefox.Size = new System.Drawing.Size(469, 20);
            this.txt_dir_firefox.TabIndex = 1;
            this.txt_dir_firefox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_dir_firefox_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dir Save Video";
            // 
            // txt_dir_save_video
            // 
            this.txt_dir_save_video.Location = new System.Drawing.Point(12, 78);
            this.txt_dir_save_video.Name = "txt_dir_save_video";
            this.txt_dir_save_video.Size = new System.Drawing.Size(469, 20);
            this.txt_dir_save_video.TabIndex = 2;
            this.txt_dir_save_video.Click += new System.EventHandler(this.txt_dir_save_video_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 179);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(469, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 215);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_dir_save_video);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dir_firefox);
            this.Controls.Add(this.label1);
            this.Name = "setting";
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dir_firefox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dir_save_video;
        private System.Windows.Forms.Button btn_save;
    }
}