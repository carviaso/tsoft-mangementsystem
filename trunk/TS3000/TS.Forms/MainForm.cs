﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TS.Forms.BusinessForm.BS;
using TS.Forms.BusinessForm;
using TS.Forms.BusinessForm.FA;

namespace TS.Forms
{
    public partial class MainForm : Form
    {
        private int _count = 0;

        public void AddForm()
        {
            _count++;
        }

        public void DelForm()
        {
            _count--;
        }



        public MainForm()
        {
            InitializeComponent();
            WelcomeForm welForm = new WelcomeForm(this);
            welForm.MdiParent = this;
            AddForm();
            welForm.Show();
        }

        private void 科目管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostListForm acc = new CostListForm();
            acc.MdiParent = this;
            _count++;
            acc.Show();
        }

        private void 收支类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaTypeForm acc = new FaTypeForm();
            acc.ShowDialog();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            
            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;

            //for each child form set the window state to Minimized
            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Minimized;
        }

        private void btnArrHoriz_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void btnArrVert_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void btnCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
 
        

       
    }
}
