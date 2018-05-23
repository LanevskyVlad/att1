namespace _1._3
{
    partial class ChangeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MedB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kurs = new System.Windows.Forms.NumericUpDown();
            this.Group = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(60, 6);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(301, 22);
            this.FIO.TabIndex = 1;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(165, 39);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(196, 22);
            this.Year.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "средние оценки";
            // 
            // MedB
            // 
            this.MedB.Location = new System.Drawing.Point(165, 73);
            this.MedB.Name = "MedB";
            this.MedB.Size = new System.Drawing.Size(196, 22);
            this.MedB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "курс";
            // 
            // Kurs
            // 
            this.Kurs.Location = new System.Drawing.Point(65, 104);
            this.Kurs.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Kurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(91, 22);
            this.Kurs.TabIndex = 7;
            this.Kurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(252, 104);
            this.Group.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(91, 22);
            this.Group.TabIndex = 9;
            this.Group.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "группа";
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(12, 147);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(90, 37);
            this.OkBtn.TabIndex = 10;
            this.OkBtn.Text = "ок";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(271, 147);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 37);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 196);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MedB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label1);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.DateTimePicker Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MedB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Kurs;
        private System.Windows.Forms.NumericUpDown Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}