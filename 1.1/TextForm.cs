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

namespace _1._1
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(openFileDialog.FileName);
                    Input.Text = file.ReadText();
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка чтения", "Error");
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.WriteText(Output.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка записи", "Error");
                }
            }
        }

        private void FiltrBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Input.Text))
            {
                MessageBox.Show("нет данных", "Error");
                return;
            }
            TextTools text = new TextTools(Input.Text);
            int N = (int)GetN.Value;
            Output.Text = text.GetWordsWithLengthN(N);
            SaveBtn.Enabled = true;
        }
    }
}
