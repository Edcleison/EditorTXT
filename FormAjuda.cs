﻿using System;
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
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();

            web.Navigate("http://www.google.com");
        }
    }
}
