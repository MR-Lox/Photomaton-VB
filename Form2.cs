using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using System.Drawing;

namespace Photomaton
{
    public partial class Form2 : Form
    {
        private const string url = "http://127.0.0.1:5000/slideshow";
        private Timer timer;

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            this.FormClosed += Form2_FormClosed;

            // Initialiser le Timer
            timer = new Timer();
            timer.Interval = 30000; // 30 secondes
            timer.Tick += Timer_Tick;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;

            if (Screen.AllScreens.Length > 1)
            {
                // Définir la position et la taille de Form2 sur le deuxième écran
                Screen secondScreen = Screen.AllScreens[1];
                this.StartPosition = FormStartPosition.Manual;
                this.Location = secondScreen.Bounds.Location;
                this.Size = secondScreen.Bounds.Size;
                this.Bounds = secondScreen.Bounds;
            }
            else
            {
                MessageBox.Show("Aucun deuxième écran disponible pour le Slideshow. Merci de connecter un 2ème écran ou vérifier le câble.");
                this.Close(); // Fermer Form2 si aucun deuxième écran n'est disponible
            }

            // Initialiser WebView2
            await webView22.EnsureCoreWebView2Async(null);
            webView22.CoreWebView2.Navigate(url);

            // Démarrer le Timer pour rafraîchir l'URL toutes les 30 secondes
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Rafraîchir l'URL dans WebView2
            webView22.CoreWebView2.Navigate(url);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Arrêter et libérer les ressources du Timer lorsque Form2 est fermé
            timer.Stop();
            timer.Dispose();
        }
    }
}
