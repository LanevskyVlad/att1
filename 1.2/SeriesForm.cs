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

namespace _1._2
{
    public partial class SeriesForm : Form
    {
        public SeriesForm()
        {
            InitializeComponent();
        }
        private List<double> GetInput()
        {
            try
            {
                return new List<double>(
                    Array.ConvertAll(Input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                    (x) => double.Parse(x)));
            }
            catch(Exception)
            {
                throw new Exception("некорректный ввод");
            }
        }
        private List<List<int>> GetOutput()
        {
            return new List<List<int>>(
                Array.ConvertAll(
                    Output.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries),
                    (str) => (
                    new List<int>(Array.ConvertAll(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                    (x) => int.Parse(x))))));
        }

        private void OpenInputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    FileTools file = new FileTools(openFileDialog.FileName);
                    file.BinReaderOpen();
                    Input.Text = String.Join(" ", file.ReadBinListDouble());
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void SaveInputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> inp = GetInput();
                if (inp.Count == 0)
                {
                    MessageBox.Show("нет данных", "Error");
                    return;
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.BinWriterOpen();
                    file.WriteBinList(inp);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void OpenOutputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(openFileDialog.FileName);
                    file.BinReaderOpen();
                    StringBuilder sb = new StringBuilder();
                    while(!file.End)
                    {
                        sb.AppendLine(String.Join(" ", file.ReadBinListInt()));
                    }
                    Output.Text = sb.ToString();
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void SaveOutputBtn_Click(object sender, EventArgs e)
        {
            List<List<int>> outp = GetOutput();
            if (outp.Count == 0)
            {
                MessageBox.Show("нет данных", "Error");
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.BinWriterOpen();
                    for (int i = 0; i < outp.Count; i++)
                    {
                        file.WriteBinList(outp[i]);
                    }
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SeriesTool series = new SeriesTool(GetInput());
                StringBuilder sb = new StringBuilder();
                List<int> list = series.GetMonotonSeriesLength();
                if (list.Count == 0) list.Add(-1);
                sb.AppendLine(string.Join(" ", list));
                list = series.GetIncreasesSeriesLength();
                if (list.Count == 0) list.Add(-1);
                sb.AppendLine(string.Join(" ", list));
                list = series.GetDecreasesSeriesLength();
                if (list.Count == 0) list.Add(-1);
                sb.AppendLine(string.Join(" ", list));
                Output.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
