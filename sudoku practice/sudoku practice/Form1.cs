using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_practice
{
    public partial class FrmSudoku : Form
    {
        public FrmSudoku()
        { InitializeComponent(); }
        private void FrmSudoku_Load(object sender, EventArgs e)
        {  }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
             Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
