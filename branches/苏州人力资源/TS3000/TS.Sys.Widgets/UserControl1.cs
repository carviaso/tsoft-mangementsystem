using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Widgets
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public DataGridView GetGridInstance
        {
            get { return this.dataGridView1; }
            set { this.dataGridView1 = value; }
        }
    }
}
