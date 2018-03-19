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
    public partial class Bank_Main : Form
    {
        private int childFormNumber = 0;

        public Bank_Main()
        {
            InitializeComponent();
        }

        private void Bank_Main_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void Bank_Main_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void Btn_Clients(object sender, EventArgs e)
        {
            Hide();
            Clients win = new Clients();
            win.Show();
        }
    }
}
