
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Photomaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            if (Screen.AllScreens.Length > 0)
            {
                this.Location = Screen.AllScreens[0].Bounds.Location;
            }
            else
            {
                MessageBox.Show("Aucun écran disponible pour afficher le Photomaton.");
            }

            // Initialiser WebView2
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("http://localhost:5000");
        }
    }
}
