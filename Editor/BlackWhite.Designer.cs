
namespace PhotoEditor
{
    partial class BlackWhite
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
            this.SavePct = new System.Windows.Forms.Button();
            this.ColorsPct = new System.Windows.Forms.Button();
            this.LoadPct = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SavePct
            // 
            this.SavePct.Location = new System.Drawing.Point(684, 261);
            this.SavePct.Name = "SavePct";
            this.SavePct.Size = new System.Drawing.Size(164, 77);
            this.SavePct.TabIndex = 11;
            this.SavePct.Text = "Сохранить";
            this.SavePct.UseVisualStyleBackColor = true;
            this.SavePct.Click += new System.EventHandler(this.SavePct_Click);
            // 
            // ColorsPct
            // 
            this.ColorsPct.Location = new System.Drawing.Point(684, 165);
            this.ColorsPct.Name = "ColorsPct";
            this.ColorsPct.Size = new System.Drawing.Size(164, 77);
            this.ColorsPct.TabIndex = 10;
            this.ColorsPct.Text = "Перекрасить";
            this.ColorsPct.UseVisualStyleBackColor = true;
            this.ColorsPct.Click += new System.EventHandler(this.ColorsPct_Click);
            // 
            // LoadPct
            // 
            this.LoadPct.Location = new System.Drawing.Point(684, 67);
            this.LoadPct.Name = "LoadPct";
            this.LoadPct.Size = new System.Drawing.Size(164, 77);
            this.LoadPct.TabIndex = 9;
            this.LoadPct.Text = "Загрузить";
            this.LoadPct.UseVisualStyleBackColor = true;
            this.LoadPct.Click += new System.EventHandler(this.LoadPct_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(357, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(26, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BlackWhite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 454);
            this.Controls.Add(this.SavePct);
            this.Controls.Add(this.ColorsPct);
            this.Controls.Add(this.LoadPct);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BlackWhite";
            this.Text = "BlackWhite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavePct;
        private System.Windows.Forms.Button ColorsPct;
        private System.Windows.Forms.Button LoadPct;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}