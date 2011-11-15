using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TS.Forms.BusinessForm.BS;
using TS.Forms.BusinessForm;
using TS.Forms.BusinessForm.FA;
using System.Collections;

namespace TS.Forms
{
    public partial class MainForm : Form
    {
        private int _count = 0;
 

        public void AddChildItem(String name,String text)
        {
            ToolStripButton childForm = new ToolStripButton(); 
            childForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            childForm.Name = name;
            childForm.Text = text;
            childForm.Size = new System.Drawing.Size(107, 22);
            childForm.Click += new System.EventHandler(this.toolStripButton_Click);
             
        }


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

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            String tset = "asdf";
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(((ToolStripButton)sender).Name))
                {
                    f.Activate();
                    break;
                }
                 
            } 
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            String tes = "adf";
        }
 
        

       
    }
}
