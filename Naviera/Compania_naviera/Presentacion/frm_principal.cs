﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compania_naviera.Presentacion
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            login frm_login = new login();
            frm_login.ShowDialog();
        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navios frm_navios = new navios();
            frm_navios.ShowDialog();
        }
    }
}