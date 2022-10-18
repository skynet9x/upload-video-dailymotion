namespace upload_video_dailymotion
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_delay = new System.Windows.Forms.TextBox();
            this.dataGridView_dailymotion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_count_video_upload_daily = new System.Windows.Forms.TextBox();
            this.txt_firefox_profile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_playlist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dailymotion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(12, 52);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(779, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delay";
            // 
            // txt_delay
            // 
            this.txt_delay.Location = new System.Drawing.Point(12, 104);
            this.txt_delay.Name = "txt_delay";
            this.txt_delay.Size = new System.Drawing.Size(106, 20);
            this.txt_delay.TabIndex = 2;
            this.txt_delay.Text = "0";
            this.txt_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_dailymotion
            // 
            this.dataGridView_dailymotion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_dailymotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dailymotion.Location = new System.Drawing.Point(12, 138);
            this.dataGridView_dailymotion.Name = "dataGridView_dailymotion";
            this.dataGridView_dailymotion.Size = new System.Drawing.Size(1114, 336);
            this.dataGridView_dailymotion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daily";
            // 
            // txt_count_video_upload_daily
            // 
            this.txt_count_video_upload_daily.Location = new System.Drawing.Point(130, 104);
            this.txt_count_video_upload_daily.Name = "txt_count_video_upload_daily";
            this.txt_count_video_upload_daily.Size = new System.Drawing.Size(106, 20);
            this.txt_count_video_upload_daily.TabIndex = 2;
            this.txt_count_video_upload_daily.Text = "40";
            this.txt_count_video_upload_daily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_firefox_profile
            // 
            this.txt_firefox_profile.Location = new System.Drawing.Point(242, 104);
            this.txt_firefox_profile.Name = "txt_firefox_profile";
            this.txt_firefox_profile.Size = new System.Drawing.Size(254, 20);
            this.txt_firefox_profile.TabIndex = 5;
            this.txt_firefox_profile.Text = "Dailymotion ticuchannel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profile Firefox";
            // 
            // txt_playlist
            // 
            this.txt_playlist.Location = new System.Drawing.Point(502, 104);
            this.txt_playlist.Name = "txt_playlist";
            this.txt_playlist.Size = new System.Drawing.Size(289, 20);
            this.txt_playlist.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Playlist ID";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "START",
            "STOP"});
            this.txt_status.Location = new System.Drawing.Point(840, 104);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(289, 21);
            this.txt_status.TabIndex = 8;
            this.txt_status.Text = "STOP";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(840, 52);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(289, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.settingToolStripMenuItem.Text = "setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 486);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_playlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_firefox_profile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_dailymotion);
            this.Controls.Add(this.txt_count_video_upload_daily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_delay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dailymotion Upload Video";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dailymotion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_delay;
        private System.Windows.Forms.DataGridView dataGridView_dailymotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_count_video_upload_daily;
        private System.Windows.Forms.TextBox txt_firefox_profile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_playlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_status;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
    }
}

