using PhotoEditor.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class BlackWhite : Form
    {
        Bitmap image;
        public BlackWhite()
        {
            InitializeComponent();
        }

        private void ColorsPct_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Please, load the image!");
                return;
            }
            Bitmap grayImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < grayImage.Width; i++)
            {
                for (int j = 0; j < grayImage.Height; j++)
                {
                    var color = image.GetPixel(i, j);
                    Color whiteOrBlack = EditorUtilities.GetWhiteOrBlackColor(color);
                    grayImage.SetPixel(i, j, whiteOrBlack);
                }
            }
            this.pictureBox2.Image = grayImage;
            this.pictureBox2.Invalidate();
        }

        private void LoadPct_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(imageDialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Invalidate();
            }
        }

        private void SavePct_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
