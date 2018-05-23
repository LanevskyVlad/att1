namespace _2
{
    partial class RootForm
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
            this.N = new System.Windows.Forms.NumericUpDown();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "выбрать расположение";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(181, 20);
            this.N.Maximum = new decimal(new int[] {
            40320,
            0,
            0,
            0});
            this.N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(70, 22);
            this.N.TabIndex = 1;
            this.N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.ValueChanged += new System.EventHandler(this.N_ValueChanged);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H});
            this.DGV.Location = new System.Drawing.Point(15, 48);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(325, 300);
            this.DGV.TabIndex = 2;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // A
            // 
            this.A.Frozen = true;
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Width = 30;
            // 
            // B
            // 
            this.B.Frozen = true;
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 30;
            // 
            // C
            // 
            this.C.Frozen = true;
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 30;
            // 
            // D
            // 
            this.D.Frozen = true;
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Width = 30;
            // 
            // E
            // 
            this.E.Frozen = true;
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            this.E.Width = 30;
            // 
            // F
            // 
            this.F.Frozen = true;
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 30;
            // 
            // G
            // 
            this.G.Frozen = true;
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Width = 30;
            // 
            // H
            // 
            this.H.Frozen = true;
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 30;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 355);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label1);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.Load += new System.EventHandler(this.RootForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
    }
}

