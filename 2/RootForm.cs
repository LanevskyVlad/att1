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
namespace _2
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }
        List<int[]> position;
        private void RootForm_Load(object sender, EventArgs e)
        {
            RookPosition roots = new RookPosition();
            position = roots.GetPositions();
            DGV.RowCount = 8;
            for (int i = 0; i < 8; i++)
                DGV.Rows[i].Height = 30;
            SetDGV(0);
        }
        private void SetDGV(int N)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if (position[N][i] == j)
                        DGV[i, j].Value = "R";
                    else
                        DGV[i, j].Value = "";
        }

        private void N_ValueChanged(object sender, EventArgs e)
        {
            SetDGV((int)N.Value - 1);
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < position.Count; i++)
            {
                if (position[i][e.ColumnIndex] == e.RowIndex)
                {
                    N.Value = i+1;
                    SetDGV(i);
                    break;
                }
            }
        }
    }
}
