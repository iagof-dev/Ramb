using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult aviso = MessageBox.Show("Não nos responsabilizamos por danos causados, Deseja continuar?", "Ram Bomber", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (aviso == DialogResult.Yes)
            {
                Form RamBomber = new Ramb();
                RamBomber.ShowDialog();
            }
            else
            {
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/n3rdydzn/ramb");
        }
    }
}
