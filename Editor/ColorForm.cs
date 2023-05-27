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
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        Bitmap image;

        static Color[] colors = new Color[] { Color.Black,Color.Purple, Color.Red, Color.Pink, Color.Salmon, Color.Coral, Color.White,
            Color.OrangeRed, Color.Bisque, Color.Yellow, Color.Coral };
        private void ColorsPct_Click(object sender, EventArgs e)
        {
            var text = this.textBox1.Text;
            var digit = 3;
            if (!string.IsNullOrEmpty(text) && text.All(x => char.IsDigit(x))) 
                digit = int.Parse(text);

            if (image == null)
            {
                MessageBox.Show("Please, load the image!");
                return;
            }
            int shift = 256 / digit; 

            Bitmap quanizationImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    int gray = EditorUtilities.GetGrayColor(image.GetPixel(i, j)).R;
                    var k = gray / shift;
                    quanizationImage.SetPixel(i, j, colors[k]);
                }
            }
            this.pictureBox2.Image = quanizationImage;
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
