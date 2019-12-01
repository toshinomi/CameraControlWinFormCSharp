using AForge.Video;
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

namespace CameraControllWindowsFormCSharp
{
    public partial class FormMain : Form
    {
        private Point m_mousePoint;
        private bool m_isDeviceExist = false;
        private FilterInfoCollection m_videoDevices;
        private VideoCaptureDevice m_videoSource = null;


        public FormMain()
        {
            InitializeComponent();

            lblTitle.MouseDown += new MouseEventHandler(OnMouseDownLblTitle);
            lblTitle.MouseMove += new MouseEventHandler(OnMouseMoveLblTitle);

            GetCameraInfo();
        }

        private void OnMouseDownLblTitle(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                m_mousePoint = new Point(e.X, e.Y);
            }

            return;
        }

        private void OnMouseMoveLblTitle(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - m_mousePoint.X;
                this.Top += e.Y - m_mousePoint.Y;
            }

            return;
        }

        private void OnClickBtnClose(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Close the application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                this.Close();
            }

            return;
        }

        private void OnClickBtnMinimizedIcon(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            return;
        }

        private void OnClickBtnGetCameraInfo(object sender, EventArgs e)
        {
            GetCameraInfo();

            return;
        }

        private void GetCameraInfo()
        {
            try
            {
                m_videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmbCamera.Items.Clear();

                if (m_videoDevices.Count <= 0)
                {
                    throw new ApplicationException();
                }

                foreach (FilterInfo device in m_videoDevices)
                {
                    cmbCamera.Items.Add(device.Name);
                    cmbCamera.SelectedIndex = 0;
                    m_isDeviceExist = true;
                }
            }
            catch (ApplicationException)
            {
                cmbCamera.Items.Add("Device does not exist");
                m_isDeviceExist = false;
            }

            return;
        }

        private void OnClickBtnStart(object sender, EventArgs e)
        {
            if (m_isDeviceExist)
            {
                m_videoSource = new VideoCaptureDevice(m_videoDevices[cmbCamera.SelectedIndex].MonikerString);
                m_videoSource.NewFrame += new NewFrameEventHandler(VideoRendering);
                CloseVideoSource();

                m_videoSource.Start();
            }

            return;
        }

        private void OnClickBtnStop(object sender, EventArgs e)
        {
            if (m_videoSource != null)
            {
                if (m_videoSource.IsRunning)
                {
                    CloseVideoSource();
                }
            }

            return;
        }

        private void VideoRendering(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = bitmap;

            return;
        }

        private void CloseVideoSource()
        {
            if (m_videoSource != null)
            {
                if (m_videoSource.IsRunning)
                {
                    m_videoSource.SignalToStop();
                    m_videoSource = null;
                }
            }

            return;
        }
    }
}