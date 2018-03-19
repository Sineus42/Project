using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Bank : Form
    {
        //private int childFormNumber = 0;

        public Bank()
        {
            InitializeComponent();
        }

        private void MainW_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void MainW_Load(object sender, EventArgs e)
        {

        }
    }

}
