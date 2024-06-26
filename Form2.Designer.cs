namespace Photomaton
{
    partial class Form2
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;

        private void InitializeComponent()
        {
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            this.SuspendLayout();
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView22.Location = new System.Drawing.Point(0, 0);
            this.webView22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(488, 301);
            this.webView22.TabIndex = 0;
            this.webView22.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 301);
            this.Controls.Add(this.webView22);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
