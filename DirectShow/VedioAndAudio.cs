using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectShow
{
    public partial class VedioAndAudio : Form
    {

        DirectXCapture d_capture = new DirectXCapture();

        public VedioAndAudio()
        {
            InitializeComponent();

            //视频设备
            foreach (DsDevice d in d_capture.videoDevices)
            {
                ListViewItem item = new ListViewItem(d.Name);
                item.Tag = d;
                videolistView.Items.Add(item);
            }
            //音频设备
            foreach (DsDevice d in d_capture.audioDevices)
            {
                ListViewItem item = new ListViewItem(d.Name);
                item.Tag = d;
                audiolistView.Items.Add(item);
            }
        }

        private void VedioAndAudio_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videolistView.SelectedItems.Count > 0)
            {
                //视频
                ListViewItem video_item = videolistView.SelectedItems[0];
                DsDevice video_dev = video_item.Tag as DsDevice;
                d_capture.video_mon = video_dev.Mon;
            }
            if (audiolistView.SelectedItems.Count > 0)
            {
                //音频
                ListViewItem audio_item = audiolistView.SelectedItems[0];
                DsDevice audio_dev = audio_item.Tag as DsDevice;
                d_capture.audio_mon = audio_dev.Mon;
            }
            //如果要保存
            if (this.SavecheckBox.Checked)
            {
                //选择保存路径
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = "采集.avi";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    d_capture.saveMediaPath = saveDialog.FileName;
                }
                else
                    return;
            }
            //如果预览
            if (this.PreviewcheckBox.Checked)
            {
                //设置预览窗口
                d_capture.previewWinOwner = this.MediaPanel.Handle;
            }
            d_capture.StartupVideo(this.SavecheckBox.Checked, this.PreviewcheckBox.Checked);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            d_capture.Stop();
        }
    }
}
