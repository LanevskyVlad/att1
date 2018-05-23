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
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }
        public Student student { get; set; } 
        private void OkBtn_Click(object sender, EventArgs e)
        {
            student.MedB = new List<double>(
                    Array.ConvertAll(MedB.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                    (x) => double.Parse(x)));
            student.FIO = FIO.Text;
            student.Year = Year.Value;
            student.Group = (byte)Group.Value;
            student.Kurs = (byte)Kurs.Value;
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            if (student == null)
                student = new Student(null, DateTime.Now, null, 0, 0);
            else
            {
                FIO.Text = student.FIO;
                Year.Value = student.Year;
                MedB.Text = string.Join(" ", student.MedB);
                Group.Value = student.Group;
                Kurs.Value = student.Kurs;
            }
        }
    }
}
