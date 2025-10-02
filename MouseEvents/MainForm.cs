using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvents
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnArkaPlanKirmizi_MouseMove(object sender, MouseEventArgs e)
        {
            lblYazi.BackColor = Color.Red;
        }

        private void btnYazininRenginiDegis_MouseHover(object sender, EventArgs e)
        {
            lblYazi.ForeColor = Color.Green;
        }
        int fontSize = 0;
        private void btnFontSizeIncrease_MouseDown(object sender, MouseEventArgs e)
        {
            fontSize = (int)lblYazi.Font.Size;
            fontSize += 5;
            lblYazi.Font = new Font("Comic Sans MS",fontSize); 
        }

        private void lblYazi_Click(object sender, EventArgs e)
        {

        }
    }
}
