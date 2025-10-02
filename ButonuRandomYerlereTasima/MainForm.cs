using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonuRandomYerlereTasima
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void btnClick_MouseMove(object sender, MouseEventArgs e)
        {
            btnClick.Location = new Point(rnd.Next(1,700),rnd.Next(1,500));
            btnClick.SetBounds(325, 50, 100, 125);
            btnClick.Left = rnd.Next(0, 120);
            btnClick.Top = rnd.Next(0, 60);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona Basıldı!");
        }
    }
}
