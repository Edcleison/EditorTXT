using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTXT
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();

            WebBrowser webSobre = new WebBrowser();
            webSobre.Dock = DockStyle.Fill;
            webSobre.Navigate(Application.StartupPath + @"sobre\index.html");
            this.Controls.Add(webSobre);
        }
    }
}
