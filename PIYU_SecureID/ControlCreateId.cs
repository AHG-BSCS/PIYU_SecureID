﻿using System;
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

namespace PIYU_SecureID
{
    public partial class ControlCreateId : UserControl
    {
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
            FormCamera cam = new FormCamera(this);
            cam.ShowDialog();
        }

        private void buttonClearPhoto_Click(object sender, EventArgs e)
        {
            pictureBoxIdPhoto.Image = null;
        }

        private void buttonSignature_Click(object sender, EventArgs e)
        {
            FormSignature sign = new FormSignature(this);
            sign.ShowDialog();
        }

        private void buttonClearSign_Click(object sender, EventArgs e)
        {
            pictureBoxSignature.Image = null;
        }
    }
}