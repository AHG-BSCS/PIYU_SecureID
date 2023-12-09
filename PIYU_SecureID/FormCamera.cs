using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace PIYU_SecureID
{
    public partial class FormCamera : Form
    {
        private ControlCreateId savePhoto;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public FormCamera(ControlCreateId savePhoto)
        {
            InitializeComponent();
            this.savePhoto = savePhoto;
            pictureBoxIdPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            InitializeWebCam();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text == "CAPTURE")
            {
                buttonSave.Text = "SAVE";
                CaptureImageFromWebcam();
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            else
            {
                this.Close();
                savePhoto.pictureBoxIdPhoto.Image = pictureBoxIdPhoto.Image;
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text == "SAVE")
            {
                InitializeWebCam();
                buttonSave.Text = "CAPTURE";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            this.Close();
        }

        private void InitializeWebCam()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                if (savePhoto.comboBoxCameras.SelectedItem != null)
                {
                    int selectedCameraIndex = savePhoto.comboBoxCameras.SelectedIndex;
                    videoSource = new VideoCaptureDevice(videoDevices[selectedCameraIndex].MonikerString);
                    videoSource.NewFrame += VideoSource_NewFrame;
                    videoSource.Start();
                }
                else
                {
                    MessageBox.Show("Please select a camera from the list.");
                }
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

        private void FormCamera_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }
    }
}
