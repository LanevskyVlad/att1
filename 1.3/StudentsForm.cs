using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
namespace _1._3
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }
        List<Student> list;
        private void OpnBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(openFileDialog.FileName);
                    file.BinReaderOpen();
                    list = file.ReadBinStudentList();
                    SetDGV();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void SetDGV()
        {
            DGV.RowCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                DGV[0, i].Value = i + 1;
                DGV[1, i].Value = list[i].FIO;
            }
        }
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            list = new List<Student>();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.BinWriterOpen();
                    file.WriteBinList(list);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeForm form = new ChangeForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    list.Add(form.student);
                    SetDGV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("некорректный ввод", "Error");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int i = DGV.CurrentCell.RowIndex;
            if(i>=0&&i<list.Count)
            {
                list.RemoveAt(i);
                SetDGV(); 
            }
        }

        private void DGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = DGV.CurrentCell.RowIndex;
            if (i >= 0 && i < list.Count)
            {
                try
                {
                    ChangeForm form = new ChangeForm();
                    form.student = list[i];
                    form.ShowDialog();
                    SetDGV();
                }
                catch (Exception)
                {
                    MessageBox.Show("некорректный ввод", "Error");
                }
            }
        }

        private void AvgBtn_Click(object sender, EventArgs e)
        {
            double[] AvgB = Student.AvgB(list);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 7; i++)
                sb.AppendLine((i + 1)+ " курс: " + AvgB[i]);
            MessageBox.Show(sb.ToString(), "средний балл");
        }
    }
}
