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
    public class GridFaCostTypeReferColumn : DataGridViewColumn
    {
        private object m_dataSoruce = null;

        public GridFaCostTypeReferColumn()
            : base(new GridFaCostTypeReferCell())
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
                if (value != null && !value.GetType().IsAssignableFrom(typeof(GridFaCostTypeReferCell)))
                {
                    throw new InvalidCastException("不是DataGridViewDataWindowCell");
                }
                base.CellTemplate = value;
            }
        }


        public GridFaCostTypeReferCell ReferCellTemplate
        {
            get
            {
                return (GridFaCostTypeReferCell)this.CellTemplate;
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
