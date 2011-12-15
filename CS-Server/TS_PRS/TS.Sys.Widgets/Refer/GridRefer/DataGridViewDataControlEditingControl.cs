﻿using System;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlEditingControl : DataControl, IDataGridViewEditingControl
    {
        protected int rowIndex;
        protected DataGridView dataGridView;
        protected bool valueChanged = false;

        public DataGridViewDataControlEditingControl()
        {
            
        }

        //重写基类
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            NotifyDataGridViewOfValueChange();
        }
        //  当text值发生变化时，通知DataGridView
        private void NotifyDataGridViewOfValueChange()
        {
            valueChanged = true;
            dataGridView.NotifyCurrentCellDirty(true);
        }
        /// <summary>
        /// 在Cell被编辑的时候光标显示
        /// </summary>
        public Cursor EditingPanelCursor
        {
            get
            {
                return Cursors.IBeam;
            }
        }
        /// <summary>
        /// 获取或设置所在的DataGridView
        /// </summary>
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }

            set
            {
                dataGridView = value;
            }
        }
         

        /// <summary>
        /// 获取或设置格式化后的值
        /// </summary>
        public object EditingControlFormattedValue
        {
            set
            {
                if (value != null)
                    Text = value.ToString();
                NotifyDataGridViewOfValueChange();
            }
            get
            {
                if (this.Value != null)
                {
                    Text = this.Value.ToString();
                }
                return this.Text;
            }

        } 

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            //Hashtable result = this.DataFetcher.GetReferResult(this.Value);
            //this.EditingControlFormattedValue = result["cName"].ToString();
        }
        /// <summary>
        /// 获取控件的Text值
        /// </summary>
        /// <param name="context">错误上下文</param>
        /// <returns></returns>
        public virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {

             
            return Text;
        }

        /// <summary>
        /// 编辑键盘
        /// </summary>
        /// <param name="keyData"></param>
        /// <param name="dataGridViewWantsInputKey"></param>
        /// <returns></returns>
        public bool EditingControlWantsInputKey(
       Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }
        public virtual bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }
        /// <summary>
        /// 控件所在行
        /// </summary>
        public int EditingControlRowIndex
        {
            get
            {
                return this.rowIndex;
            }

            set
            {
                this.rowIndex = value;
            }
        }
        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="dataGridViewCellStyle"></param>
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }
        /// <summary>
        /// 是否值发生了变化
        /// </summary>
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }

            set
            {
                this.valueChanged = value;
            }
        }

       
    }
}
