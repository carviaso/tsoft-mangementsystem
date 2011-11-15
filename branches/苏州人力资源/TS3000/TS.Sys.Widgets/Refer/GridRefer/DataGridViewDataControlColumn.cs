using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Widgets.Refer.Fetcher.Refer;
using TS.Sys.Widgets.Refer.Fetcher.Refer.Impl;
using TS.Sys.Widgets.Refer.Control;

namespace TS.Sys.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlColumn : DataGridViewColumn
    {
        private object m_dataSoruce = null; 

        public DataGridViewDataControlColumn() : base(new DataGridViewDataControlCell())
        {
 

        }
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewDataControlCell)))
                {
                    throw new InvalidCastException("不是DataGridViewDataWindowCell");
                }
                base.CellTemplate = value;
            }
        }
         
        
        public DataGridViewDataControlCell ReferCellTemplate
        {
            get
            {
                return (DataGridViewDataControlCell)this.CellTemplate;
            }
        }

       
        public Object DataSource
        {
            get
            {
                return m_dataSoruce;

            }
            set
            {
                if (ReferCellTemplate != value)
                {
             
                    m_dataSoruce = value;
                   
                }
            }
        }
    }
}
