
namespace PhotoEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrayBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.OrderListDataGrid = new System.Windows.Forms.DataGridView();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.BlackWhiteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформленные заказы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбор клиента:";
            // 
            // GrayBtn
            // 
            this.GrayBtn.Location = new System.Drawing.Point(663, 78);
            this.GrayBtn.Name = "GrayBtn";
            this.GrayBtn.Size = new System.Drawing.Size(195, 73);
            this.GrayBtn.TabIndex = 2;
            this.GrayBtn.Text = "Серое оформление";
            this.GrayBtn.UseVisualStyleBackColor = true;
            this.GrayBtn.Click += new System.EventHandler(this.GrayBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Услуги:";
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(663, 188);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(195, 73);
            this.ColorBtn.TabIndex = 4;
            this.ColorBtn.Text = "Оформление в нескольких цветах";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // OrderListDataGrid
            // 
            this.OrderListDataGrid.AllowUserToAddRows = false;
            this.OrderListDataGrid.AllowUserToDeleteRows = false;
            this.OrderListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGrid.Location = new System.Drawing.Point(30, 61);
            this.OrderListDataGrid.Name = "OrderListDataGrid";
            this.OrderListDataGrid.ReadOnly = true;
            this.OrderListDataGrid.RowHeadersWidth = 51;
            this.OrderListDataGrid.RowTemplate.Height = 24;
            this.OrderListDataGrid.Size = new System.Drawing.Size(598, 265);
            this.OrderListDataGrid.TabIndex = 5;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(31, 381);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(597, 24);
            this.ClientComboBox.TabIndex = 6;
            this.ClientComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientComboBox_SelectedIndexChanged);
            // 
            // BlackWhiteBtn
            // 
            this.BlackWhiteBtn.Location = new System.Drawing.Point(663, 295);
            this.BlackWhiteBtn.Name = "BlackWhiteBtn";
            this.BlackWhiteBtn.Size = new System.Drawing.Size(195, 73);
            this.BlackWhiteBtn.TabIndex = 7;
            this.BlackWhiteBtn.Text = "Черно-белое оформление";
            this.BlackWhiteBtn.UseVisualStyleBackColor = true;
            this.BlackWhiteBtn.Click += new System.EventHandler(this.BlackWhiteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 547);
            this.Controls.Add(this.BlackWhiteBtn);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.OrderListDataGrid);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrayBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PhotoStudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GrayBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.DataGridView OrderListDataGrid;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.Button BlackWhiteBtn;
    }
}

