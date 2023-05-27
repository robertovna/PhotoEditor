
namespace PhotoEditor
{
    partial class Gray
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
            this.GrayBtn = new System.Windows.Forms.Button();
            this.LoadPct = new System.Windows.Forms.Button();
            this.SavePct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(28, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(362, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // GrayBtn
            // 
            this.GrayBtn.Location = new System.Drawing.Point(678, 175);
            this.GrayBtn.Name = "GrayBtn";
            this.GrayBtn.Size = new System.Drawing.Size(164, 77);
            this.GrayBtn.TabIndex = 2;
            this.GrayBtn.Text = "Перекрасить";
            this.GrayBtn.UseVisualStyleBackColor = true;
            this.GrayBtn.Click += new System.EventHandler(this.GrayBtn_Click);
            // 
            // LoadPct
            // 
            this.LoadPct.Location = new System.Drawing.Point(678, 78);
            this.LoadPct.Name = "LoadPct";
            this.LoadPct.Size = new System.Drawing.Size(164, 77);
            this.LoadPct.TabIndex = 3;
            this.LoadPct.Text = "Загрузить";
            this.LoadPct.UseVisualStyleBackColor = true;
            this.LoadPct.Click += new System.EventHandler(this.LoadPct_Click);
            // 
            // SavePct
            // 
            this.SavePct.Location = new System.Drawing.Point(678, 278);
            this.SavePct.Name = "SavePct";
            this.SavePct.Size = new System.Drawing.Size(164, 77);
            this.SavePct.TabIndex = 4;
            this.SavePct.Text = "Сохранить";
            this.SavePct.UseVisualStyleBackColor = true;
            this.SavePct.Click += new System.EventHandler(this.SavePct_Click);
            // 
            // Gray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 478);
            this.Controls.Add(this.SavePct);
            this.Controls.Add(this.LoadPct);
            this.Controls.Add(this.GrayBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gray";
            this.Text = "Gray";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GrayBtn;
        private System.Windows.Forms.Button LoadPct;
        private System.Windows.Forms.Button SavePct;
    }
}