﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.CONTROLES.COMPONENTES
{
    public partial class FlaskTextBox : TextBox
    {
        public bool CampoObrigatorio { get; set; }
        public FlaskTextBox()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
