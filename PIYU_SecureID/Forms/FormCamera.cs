using System;
using AForge.Video.DirectShow;
using AForge.Video;
using PIYU_SecureID.Classes;

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
            DesignHelper.PaintRoundBorder(this);
            this.savePhoto = savePhoto;
            picBoxCameraDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            InitializeWebCam();
            Thread.Sleep(1000);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "CAPTURE")
            {
                btnSave.Text = "SAVE";
                CaptureImageFromWebcam();
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            else
            {
                this.Close();
                savePhoto.pictureBoxIdPhoto.Image = picBoxCameraDisplay.Image;
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "SAVE")
            {
                InitializeWebCam();
                btnSave.Text = "CAPTURE";
            }
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

            picBoxCameraDisplay.Image = squareFrame;
        }

        private void CaptureImageFromWebcam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap capturedImage = (Bitmap)picBoxCameraDisplay.Image.Clone();

                picBoxCameraDisplay.Image = capturedImage;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            this.Close();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
    }
}
