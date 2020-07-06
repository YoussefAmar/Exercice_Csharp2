using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_pas
{
    public partial class FP : Form
    {
        public FP()
        {
            InitializeComponent();
        }

        private void bSpeedy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je suis Speedy Gonzales, la souris la plus rapide de tout l'ouest");
        }

        private void tBUser_Enter(object sender, EventArgs e)
        {
            tBUser.Text = "--------";
        }

        private void tBPasswd_Enter(object sender, EventArgs e)
        {
            tBPasswd.Text = "-------";
            tBPasswd.PasswordChar = '*';
        }

        private void bAffiche_Click(object sender, EventArgs e)
        {

                this.Text = tBUser.Text + " - " + tBPasswd.Text;

        }

        private void FP_Load(object sender, EventArgs e)
        {
            
        }
    }
}
