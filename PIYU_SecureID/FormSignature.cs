using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIYU_SecureID
{
    public partial class FormSignature : Form
    {
        private Point previousPoint;
        private bool isDrawing;
        private ControlCreateId saveSign;
        public FormSignature(ControlCreateId saveSign)
        {
            InitializeComponent();
            this.saveSign = saveSign;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSignature();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearSignature();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxSignature_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint = e.Location;
            isDrawing = true;
        }

        private void pictureBoxSignature_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = pictureBoxSignature.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;
            }
        }

        private void pictureBoxSignature_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        public Bitmap GetSignature()
        {
            Bitmap signature = new Bitmap(pictureBoxSignature.Width, pictureBoxSignature.Height);
            using (Graphics g = Graphics.FromImage(signature))
            {
                g.CopyFromScreen(pictureBoxSignature.PointToScreen(Point.Empty), Point.Empty, pictureBoxSignature.Size);
            }

            Rectangle boundingBox = FindBoundingBox(signature);

            int size = Math.Max(boundingBox.Width, boundingBox.Height);

            int x = boundingBox.X + (boundingBox.Width - size) / 2;
            int y = boundingBox.Y + (boundingBox.Height - size) / 2;

            Bitmap croppedSignature = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(croppedSignature))
            {
                g.DrawImage(signature, 0, 0, new Rectangle(x, y, size, size), GraphicsUnit.Pixel);
            }

            return croppedSignature;
        }

        private Rectangle FindBoundingBox(Bitmap image)
        {
            int threshold = 128;
            int minX = image.Width - 1;
            int minY = image.Height - 1;
            int maxX = 0;
            int maxY = 0;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    if (pixelColor.GetBrightness() < threshold) // Check if pixel is dark (inked)
                    {
                        minX = Math.Min(minX, x);
                        minY = Math.Min(minY, y);
                        maxX = Math.Max(maxX, x);
                        maxY = Math.Max(maxY, y);
                    }
                }
            }

            // Ensure the bounding box has a minimum size
            int minWidth = 10;
            int minHeight = 10;
            int width = Math.Max(maxX - minX + 1, minWidth);
            int height = Math.Max(maxY - minY + 1, minHeight);

            return new Rectangle(minX, minY, width, height);
        }


        private void SaveSignature()
        {
            Bitmap signature = GetSignature();
            saveSign.pictureBoxSignature.Image = signature;
            ClearSignature();
        }

        public void ClearSignature()
        {
            pictureBoxSignature.Image = null;
        }
    }
}
