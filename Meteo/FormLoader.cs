﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteo
{
    public partial class FormLoader : Form
    {
        public FormLoader(string message)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            labelMessage.Text = message;
        }
    }
}
