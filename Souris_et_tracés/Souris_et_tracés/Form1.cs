using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Souris_et_tracés
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();

        }

        private void bTempete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention, avis de tempête");
        }

        private void bTitre_Click(object sender, EventArgs e)
        {
            this.Text = "Carte marine - Ile de Noirmoutier";
            bTempete.Text = "MESSAGE";
            bCouleur_bouton.Text = "COULEUR";
            bTitre.Text = "TITRE";
            bEllipse.Text = "ELLIPSE";
        }

        private void bCouleur_bouton_Click(object sender, EventArgs e)
        {
            bEllipse.BackColor = Color.Violet;
            bEllipse.ForeColor = Color.DarkBlue;
            bTitre.ForeColor = Color.DarkRed;
            bTitre.BackColor = Color.Turquoise;
            bTempete.ForeColor = Color.DarkGreen;
            bTempete.BackColor = Color.Tomato;
            bCouleur_bouton.ForeColor = Color.DarkMagenta;
            bCouleur_bouton.BackColor = Color.Silver;
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void F_Principal_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void F_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Black, 8), bBateau.Location.X, bBateau.Location.Y, 5, 5);
            }

                bBateau.Location = new Point(e.X, e.Y);

        }
        private void bEllipse_Click(object sender, EventArgs e)
        {
            using( Graphics g = CreateGraphics())
            {
                g.DrawEllipse(new Pen(Color.Red,5), 10, 110, 50, 50);
            }
        }
    }
}
