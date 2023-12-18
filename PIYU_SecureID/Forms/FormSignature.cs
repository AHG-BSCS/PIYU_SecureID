using System;

namespace PIYU_SecureID
{
    public partial class FormSignature : Form
    {
        private Point previousPoint;
        private Pen signaturePen;
        private bool isDrawing;
        private ControlCreateId saveSign;

        public FormSignature(ControlCreateId saveSign)
        {
            InitializeComponent();
            this.saveSign = saveSign;
            this.signaturePen = CreateSignaturePen();
        }

        private Pen CreateSignaturePen()
        {
            Pen signaturePen = new Pen(Color.Black);
            signaturePen.Width = 3;
            signaturePen.StartCap = signaturePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            signaturePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            signaturePen.MiterLimit = 10;

            return signaturePen;
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

        private void pictureBoxSignature_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint = e.Location;
            isDrawing = true;
        }

        private void pictureBoxSignature_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = picBoxSignatureDrawing.CreateGraphics())
                {
                    g.DrawLine(signaturePen, previousPoint, e.Location);
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
            Bitmap signature = new Bitmap(picBoxSignatureDrawing.Width, picBoxSignatureDrawing.Height);
            using (Graphics g = Graphics.FromImage(signature))
            {
                g.CopyFromScreen(picBoxSignatureDrawing.PointToScreen(Point.Empty), Point.Empty, picBoxSignatureDrawing.Size);
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
            saveSign.picBoxSignature.Image = signature;
            ClearSignature();
        }

        public void ClearSignature()
        {
            picBoxSignatureDrawing.Image = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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
