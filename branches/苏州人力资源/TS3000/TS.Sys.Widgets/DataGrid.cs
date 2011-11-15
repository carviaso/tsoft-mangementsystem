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
    public partial class DataGrid : UserControl
    {
        public DataGrid()
        {
            InitializeComponent();
        }
 

        public DataGridView DataGridControl
        {
            get { return this.dataGridView; }
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }
    }
}
