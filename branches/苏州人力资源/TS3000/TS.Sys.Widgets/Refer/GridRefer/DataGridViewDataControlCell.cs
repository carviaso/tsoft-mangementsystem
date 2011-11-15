using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;
using TS.Sys.Widgets.Refer.Fetcher.Refer;
using TS.Sys.Widgets.Refer.Control;

namespace TS.Sys.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlCell:DataGridViewTextBoxCell
    {
         

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DataGridViewDataControlEditingControl dataWindowControl  = DataGridView.EditingControl as DataGridViewDataControlEditingControl;
            DataGridViewDataControlColumn dataWindowColumn = (DataGridViewDataControlColumn)OwningColumn;
            //dataWindowControl.
             dataWindowControl.DataSource = dataWindowColumn.DataSource;
            dataWindowControl.Text = (string)this.Value ;
            
        }
 
        [Browsable(false)]
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewDataControlEditingControl);
            }
        } 

        public override Type ValueType
        {
            get
            {
                return typeof(object);
            }
        }
          
    }
}
