using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Claims;
using AForge.Video;
using AForge.Video.DirectShow;

namespace PIYU_SecureID
{
    public partial class ControlCreateId : UserControl
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public ControlCreateId()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBoxIdPhoto.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            if (buttonCamera.Text == "Take a Photo")
            {
                buttonCamera.Text = "Capture";
                InitializeWebCam();
            }
            else
            {
                buttonCamera.Text = "Take a Photo";
                CaptureImageFromWebcam();
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void InitializeWebCam()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap originalFrame = (Bitmap)eventArgs.Frame.Clone();

            int size = Math.Min(originalFrame.Width, originalFrame.Height);
            Rectangle cropArea = new Rectangle((originalFrame.Width - size) / 2, (originalFrame.Height - size) / 2, size, size);
            Bitmap squareFrame = originalFrame.Clone(cropArea, originalFrame.PixelFormat);

            pictureBoxIdPhoto.Image = squareFrame;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            CaptureImageFromWebcam();
        }

        private void CaptureImageFromWebcam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap capturedImage = (Bitmap)pictureBoxIdPhoto.Image.Clone();

                pictureBoxIdPhoto.Image = capturedImage;
            }
            else
            {
                MessageBox.Show("Webcam not available or not started.");
            }
        }

        private void buttonClearPhoto_Click(object sender, EventArgs e)
        {
            pictureBoxIdPhoto.Image = null;
        }
    }
}
