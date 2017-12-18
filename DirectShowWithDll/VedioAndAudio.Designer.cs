namespace DirectShowWithDll
{
    partial class VedioAndAudio
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviewcheckBox = new System.Windows.Forms.CheckBox();
            this.SavecheckBox = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.comboBoxVedio = new System.Windows.Forms.ComboBox();
            this.comboBoxAudio = new System.Windows.Forms.ComboBox();
            this.labelVedio = new System.Windows.Forms.Label();
            this.labelAudio = new System.Windows.Forms.Label();
            this.pictureBoxCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewcheckBox
            // 
            this.PreviewcheckBox.AutoSize = true;
            this.PreviewcheckBox.Checked = true;
            this.PreviewcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PreviewcheckBox.Location = new System.Drawing.Point(466, 23);
            this.PreviewcheckBox.Name = "PreviewcheckBox";
            this.PreviewcheckBox.Size = new System.Drawing.Size(48, 16);
            this.PreviewcheckBox.TabIndex = 0;
            this.PreviewcheckBox.Text = "预览";
            this.PreviewcheckBox.UseVisualStyleBackColor = true;
            // 
            // SavecheckBox
            // 
            this.SavecheckBox.AutoSize = true;
            this.SavecheckBox.Location = new System.Drawing.Point(519, 23);
            this.SavecheckBox.Name = "SavecheckBox";
            this.SavecheckBox.Size = new System.Drawing.Size(48, 16);
            this.SavecheckBox.TabIndex = 1;
            this.SavecheckBox.Text = "保存";
            this.SavecheckBox.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(591, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(682, 18);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // comboBoxVedio
            // 
            this.comboBoxVedio.FormattingEnabled = true;
            this.comboBoxVedio.Location = new System.Drawing.Point(69, 22);
            this.comboBoxVedio.Name = "comboBoxVedio";
            this.comboBoxVedio.Size = new System.Drawing.Size(157, 20);
            this.comboBoxVedio.TabIndex = 7;
            // 
            // comboBoxAudio
            // 
            this.comboBoxAudio.FormattingEnabled = true;
            this.comboBoxAudio.Location = new System.Drawing.Point(295, 22);
            this.comboBoxAudio.Name = "comboBoxAudio";
            this.comboBoxAudio.Size = new System.Drawing.Size(153, 20);
            this.comboBoxAudio.TabIndex = 8;
            // 
            // labelVedio
            // 
            this.labelVedio.AutoSize = true;
            this.labelVedio.Location = new System.Drawing.Point(8, 25);
            this.labelVedio.Name = "labelVedio";
            this.labelVedio.Size = new System.Drawing.Size(59, 12);
            this.labelVedio.TabIndex = 9;
            this.labelVedio.Text = "视频设备:";
            // 
            // labelAudio
            // 
            this.labelAudio.AutoSize = true;
            this.labelAudio.Location = new System.Drawing.Point(234, 26);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Size = new System.Drawing.Size(59, 12);
            this.labelAudio.TabIndex = 10;
            this.labelAudio.Text = "音频设备:";
            // 
            // pictureBoxCapture
            // 
            this.pictureBoxCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCapture.Location = new System.Drawing.Point(10, 49);
            this.pictureBoxCapture.Name = "pictureBoxCapture";
            this.pictureBoxCapture.Size = new System.Drawing.Size(751, 440);
            this.pictureBoxCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCapture.TabIndex = 11;
            this.pictureBoxCapture.TabStop = false;
            // 
            // VedioAndAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 510);
            this.Controls.Add(this.pictureBoxCapture);
            this.Controls.Add(this.labelAudio);
            this.Controls.Add(this.labelVedio);
            this.Controls.Add(this.comboBoxAudio);
            this.Controls.Add(this.comboBoxVedio);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.SavecheckBox);
            this.Controls.Add(this.PreviewcheckBox);
            this.Name = "VedioAndAudio";
            this.Text = "VedioAndAudio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PreviewcheckBox;
        private System.Windows.Forms.CheckBox SavecheckBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox comboBoxVedio;
        private System.Windows.Forms.ComboBox comboBoxAudio;
        private System.Windows.Forms.Label labelVedio;
        private System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.PictureBox pictureBoxCapture;
    }
}

