using AForge.Video.DirectShow;
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
    public partial class DirectShow : Form
    {
        VideoCaptureDevice _videoSource;//视频抓取设备对象
        public DirectShow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化窗体加载及视频设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirectShow_Load(object sender, EventArgs e)
        {
            // enumerate video devices
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevices)
            {
                comboBox1.Items.Add(videoDevice);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.DisplayMember = "Name";
                comboBox1.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 开启摄像功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            FilterInfo videoDevice = (FilterInfo)comboBox1.Items[comboBox1.SelectedIndex];
            _videoSource = new VideoCaptureDevice(videoDevice.MonikerString);
            _videoSource.NewFrame += VideoSource_NewFrame;// 更新帧图
            _videoSource.Start();
        }

        /// <summary>
        /// 停止摄像功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_videoSource != null)
                _videoSource.Stop();
        }

        /// <summary>
        /// 摄像头帧图片获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (eventArgs.Frame != null)
            {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();

                Rectangle bmpRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(bmpRect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
                AForge.Imaging.Drawing.Rectangle(bmpData, new Rectangle(10, 10, 100, 100), Color.Green);
                bmp.UnlockBits(bmpData);
                pictureBox1.Image = bmp;
            }

        }
    }
}
