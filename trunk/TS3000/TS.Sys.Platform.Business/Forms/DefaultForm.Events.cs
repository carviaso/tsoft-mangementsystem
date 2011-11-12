﻿using System;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;

namespace TS.Sys.Platform.Business.Forms
{
    partial class DefaultForm
    {
        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            BusinessControl.SetNewEditStatus(toolBtn);
            BusinessControl.ClearControlValue(tpControl);
            if (formEvents != null)
            {
                formEvents.New();
            }
        }

        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            //构造fi
            BusinessControl.SetInfoProperties(info, tpControl);
            //保存时新增还是修改
            if (info.cGUID != null && !String.IsNullOrEmpty(info.cGUID.ToString()))
            {
                if (formEvents != null)
                {
                    formEvents.Modify();
                } 
            }
            else
            {
                if (formEvents != null)
                {
                    formEvents.Add();
                } 
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("删除" + this.Text, SysConst.msgDeleteConfirm, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult.Equals(DialogResult.Cancel))
            {
                return;
            }
            if (formEvents != null)
            {
                formEvents.Delete();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Type t = this.GetType();
            MethodInfo mi = t.GetMethod("btnInfo_Click", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
            mi.Invoke(this, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rowIndex == dgRowCollection.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                rowIndex++;
                InitBillFormContent(rowIndex);
            }
        }

        void btnPre_Click(object sender, EventArgs e)
        {
            if (rowIndex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                rowIndex--;
                InitBillFormContent(rowIndex);
            }
        }

        void btnLast_Click(object sender, EventArgs e)
        {
            if (rowIndex == dgRowCollection.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                rowIndex = dgRowCollection.Count - 1;
                InitBillFormContent(rowIndex);
            }
        }

        void btnFirst_Click(object sender, EventArgs e)
        {
            if (rowIndex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                rowIndex = 0;
                InitBillFormContent(rowIndex);
            }
        }
    }
}
