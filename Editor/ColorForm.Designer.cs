
namespace PhotoEditor
{
    partial class ColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoadPct = new System.Windows.Forms.Button();
            this.ColorsPct = new System.Windows.Forms.Button();
            this.SavePct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(23, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(354, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LoadPct
            // 
            this.LoadPct.Location = new System.Drawing.Point(681, 87);
            this.LoadPct.Name = "LoadPct";
            this.LoadPct.Size = new System.Drawing.Size(164, 77);
            this.LoadPct.TabIndex = 4;
            this.LoadPct.Text = "Загрузить";
            this.LoadPct.UseVisualStyleBackColor = true;
            this.LoadPct.Click += new System.EventHandler(this.LoadPct_Click);
            // 
            // ColorsPct
            // 
            this.ColorsPct.Location = new System.Drawing.Point(681, 185);
            this.ColorsPct.Name = "ColorsPct";
            this.ColorsPct.Size = new System.Drawing.Size(164, 77);
            this.ColorsPct.TabIndex = 5;
            this.ColorsPct.Text = "Перекрасить";
            this.ColorsPct.UseVisualStyleBackColor = true;
            this.ColorsPct.Click += new System.EventHandler(this.ColorsPct_Click);
            // 
            // SavePct
            // 
            this.SavePct.Location = new System.Drawing.Point(681, 281);
            this.SavePct.Name = "SavePct";
            this.SavePct.Size = new System.Drawing.Size(164, 77);
            this.SavePct.TabIndex = 6;
            this.SavePct.Text = "Сохранить";
            this.SavePct.UseVisualStyleBackColor = true;
            this.SavePct.Click += new System.EventHandler(this.SavePct_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SavePct);
            this.Controls.Add(this.ColorsPct);
            this.Controls.Add(this.LoadPct);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ColorForm";
            this.Text = "Color";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LoadPct;
        private System.Windows.Forms.Button ColorsPct;
        private System.Windows.Forms.Button SavePct;
        private System.Windows.Forms.TextBox textBox1;
    }
}