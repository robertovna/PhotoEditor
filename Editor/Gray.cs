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
    public partial class Gray : Form
    {
        Bitmap image;

        public Gray()
        {
            InitializeComponent();
        }

        private void GrayBtn_Click(object sender, EventArgs e)
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
                    Color gray = EditorUtilities.GetGrayColor(image.GetPixel(i, j));
                    grayImage.SetPixel(i, j, gray);
                }
            }
            pictureBox2.Image = grayImage;
            pictureBox2.Invalidate();
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
