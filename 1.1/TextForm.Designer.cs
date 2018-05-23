namespace _1._1
{
    partial class TextForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GetN = new System.Windows.Forms.NumericUpDown();
            this.FiltrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Input.txt";
            this.openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|все файлы|*.*";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 61);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(392, 420);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(410, 61);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(392, 420);
            this.Output.TabIndex = 1;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 25);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(119, 30);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "открыть файл";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(680, 25);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(124, 30);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "сохранить файл";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "N = ";
            // 
            // GetN
            // 
            this.GetN.Location = new System.Drawing.Point(177, 30);
            this.GetN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.GetN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GetN.Name = "GetN";
            this.GetN.Size = new System.Drawing.Size(53, 22);
            this.GetN.TabIndex = 5;
            this.GetN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FiltrBtn
            // 
            this.FiltrBtn.Location = new System.Drawing.Point(303, 25);
            this.FiltrBtn.Name = "FiltrBtn";
            this.FiltrBtn.Size = new System.Drawing.Size(101, 30);
            this.FiltrBtn.TabIndex = 6;
            this.FiltrBtn.Text = "Выборка";
            this.FiltrBtn.UseVisualStyleBackColor = true;
            this.FiltrBtn.Click += new System.EventHandler(this.FiltrBtn_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.Controls.Add(this.FiltrBtn);
            this.Controls.Add(this.GetN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "TextForm";
            this.Text = "TextForm";
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GetN;
        private System.Windows.Forms.Button FiltrBtn;
    }
}

