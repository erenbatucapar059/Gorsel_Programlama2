using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseIleButonTasima
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool aktiflik = false;
        Point konumu;
        private void btnMove_MouseDown(object sender, MouseEventArgs e)
        {
            aktiflik = true;
            konumu = e.Location;
        }

        private void btnMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (aktiflik)
            {
                if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                {
                    btnMove.Left = e.X + btnMove.Left - konumu.X;
                    btnMove.Top = e.Y + btnMove.Top - konumu.Y;
                }
            }
        }

        private void btnMove_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                aktiflik = false;
            }
        }
    }
}
