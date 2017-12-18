using DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectShowWithDll//参考地址：http://blog.csdn.net/da1da1xue/article/details/44975705
{
    public partial class VedioAndAudio : Form
    {
        DirectXCapture d_capture = new DirectXCapture();
        ListViewItem vedioListView;
        ListViewItem audioListView;

        public VedioAndAudio()
        {
            InitializeComponent();

            //视频设备
            foreach (DsDevice d in d_capture.videoDevices)
            {
                comboBoxVedio.Items.Add(d.Name);
                vedioListView = new ListViewItem(d.Name);
                vedioListView.Tag = d;
            }
            //音频设备
            foreach (DsDevice d in d_capture.audioDevices)
            {
                comboBoxAudio.Items.Add(d.Name);
                audioListView = new ListViewItem(d.Name);
                audioListView.Tag = d;
            }
            comboBoxVedio.SelectedIndex = 0;
            comboBoxAudio.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //视频
            DsDevice video_dev = vedioListView.Tag as DsDevice;
            d_capture.video_mon = video_dev.Mon;

            //音频
            DsDevice audio_dev = audioListView.Tag as DsDevice;
            d_capture.audio_mon = audio_dev.Mon;

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
            }
            //如果预览
            if (this.PreviewcheckBox.Checked)
            {
                //设置预览窗口
                d_capture.previewWinOwner = this.pictureBoxCapture.Handle;
            }
            d_capture.StartupVideo(this.SavecheckBox.Checked, this.PreviewcheckBox.Checked);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            d_capture.Stop();
        }
    }
}
