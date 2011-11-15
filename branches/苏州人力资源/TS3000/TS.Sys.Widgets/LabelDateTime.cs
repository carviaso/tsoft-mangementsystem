using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Widgets
{
    public partial class LabelDateTime : UserControl
    {
        public LabelDateTime()
        {
            InitializeComponent();
        }

         

        /// <summary>
        /// 标签
        /// </summary>
        public string Label
        {
            set { this.label.Text = value; }
            get { return this.label.Text; }
        }

        private bool _requireFlag;
        private RequireSelect _require; 
        public enum RequireSelect
        {
            True,
            False,
        }


        public RequireSelect Require
        {
            set
            {
                if (value == RequireSelect.True)
                {
                    _requireFlag = true;
                }
                else
                {
                    _requireFlag = false;
                }

            }
            get
            {
                if (_requireFlag)
                { 
                    return RequireSelect.True; 
                }
                else
                {
                    return RequireSelect.False;
                }
            }

        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public new Boolean Enabled
        {
            set
            {
                this.dateTimePicker.Enabled = value;
            }
            get
            {
                return this.dateTimePicker.Enabled;
            }
        }

        public Label LabelCtrl
        {
            get { return this.label; }
        }

        public DateTimePicker DateTime
        {
            get { return this.dateTimePicker; }
        }

        public Object Value
        {
            set { if (value != null && !String.IsNullOrEmpty(value.ToString())) { this.dateTimePicker.Value = Convert.ToDateTime(value); } }
            get { return this.dateTimePicker.Value.ToShortDateString(); }
        }

        /// <summary>
        /// 设置标签宽度
        /// </summary>
        public int LabelWidth
        {
            set
            {
                this.label.Width = value;
                this.tableLayoutPanel1.ColumnStyles[0].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[0].Width; }
        }

        /// <summary>
        /// 设置日期框宽度
        /// </summary>
        public int DateTimeWidth
        {
            set
            {
                this.dateTimePicker.Width = value;
                this.tableLayoutPanel1.ColumnStyles[1].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[1].Width; }
        }

        public event EventHandler ValueChanged;

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e); 
        }

         

    }
}
