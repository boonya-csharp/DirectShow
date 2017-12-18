namespace DirectShow
{
    partial class VedioAndAudio
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
            this.videolistView = new System.Windows.Forms.ListView();
            this.audiolistView = new System.Windows.Forms.ListView();
            this.PreviewcheckBox = new System.Windows.Forms.CheckBox();
            this.SavecheckBox = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.MediaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // videolistView
            // 
            this.videolistView.Location = new System.Drawing.Point(13, 77);
            this.videolistView.Name = "videolistView";
            this.videolistView.Size = new System.Drawing.Size(364, 115);
            this.videolistView.TabIndex = 0;
            this.videolistView.UseCompatibleStateImageBehavior = false;
            // 
            // audiolistView
            // 
            this.audiolistView.Location = new System.Drawing.Point(13, 232);
            this.audiolistView.Name = "audiolistView";
            this.audiolistView.Size = new System.Drawing.Size(364, 121);
            this.audiolistView.TabIndex = 1;
            this.audiolistView.UseCompatibleStateImageBehavior = false;
            // 
            // PreviewcheckBox
            // 
            this.PreviewcheckBox.AutoSize = true;
            this.PreviewcheckBox.Location = new System.Drawing.Point(13, 29);
            this.PreviewcheckBox.Name = "PreviewcheckBox";
            this.PreviewcheckBox.Size = new System.Drawing.Size(48, 16);
            this.PreviewcheckBox.TabIndex = 2;
            this.PreviewcheckBox.Text = "预览";
            this.PreviewcheckBox.UseVisualStyleBackColor = true;
            // 
            // SavecheckBox
            // 
            this.SavecheckBox.AutoSize = true;
            this.SavecheckBox.Location = new System.Drawing.Point(91, 29);
            this.SavecheckBox.Name = "SavecheckBox";
            this.SavecheckBox.Size = new System.Drawing.Size(48, 16);
            this.SavecheckBox.TabIndex = 3;
            this.SavecheckBox.Text = "保存";
            this.SavecheckBox.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(278, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(406, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MediaPanel
            // 
            this.MediaPanel.Location = new System.Drawing.Point(417, 77);
            this.MediaPanel.Name = "MediaPanel";
            this.MediaPanel.Size = new System.Drawing.Size(302, 276);
            this.MediaPanel.TabIndex = 6;
            // 
            // VedioAndAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 390);
            this.Controls.Add(this.MediaPanel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.SavecheckBox);
            this.Controls.Add(this.PreviewcheckBox);
            this.Controls.Add(this.audiolistView);
            this.Controls.Add(this.videolistView);
            this.Name = "VedioAndAudio";
            this.Text = "VedioAndAudio";
            this.Load += new System.EventHandler(this.VedioAndAudio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView videolistView;
        private System.Windows.Forms.ListView audiolistView;
        private System.Windows.Forms.CheckBox PreviewcheckBox;
        private System.Windows.Forms.CheckBox SavecheckBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel MediaPanel;
    }
}