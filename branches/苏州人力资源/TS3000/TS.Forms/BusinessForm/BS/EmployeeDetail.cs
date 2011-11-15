using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service; 
using TS.Sys.Util;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class EmployeeDetailForm : Form
    {
        private bool editFlag = false;
        private EmployeeService empService;
        private EmployeeInfo empInfo;
        private EmployeeForm empForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;

        public EmployeeDetailForm()
        {
            InitializeComponent();
            empService = new EmployeeService();
            this.tbControl.TabPages[0].Text = "职员属性";
        }

        internal EmployeeForm EmpForm
        {
            set { this.empForm = value; }
        }
        
        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public EmployeeDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            _rowindex = rowIndex;
            this._ds = ds;           
            InitBillFormContent(rowIndex);
        }
         
        private void InitBillFormContent(int rowIndex)
        {
             
            DataGridViewRow r = _ds[rowIndex]; 
            Object cGUID = r.Cells["cGUID"].Value;
            this.tbControl.TabPages[0].Text = r.Cells["cName"].Value + "的属性";
            //ArrayList mainResult = empService.GetResultByGUID(cGUID);
            //BillForm.SetMainContent(empInfo, mainResult, tpControl);  
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Object a = this.iSex.comboBox.SelectedValue;
            saveAction();
            btnSave.Enabled = false;
        }

        private void saveAction()
        {

            EmployeeInfo emp = new EmployeeInfo();
            BusinessControl.SetInfoProperties(emp, tpControl);
            if (cGUID.Value != null && !String.IsNullOrEmpty((string)cGUID.Value))
            {
                  
                empService.Modify(emp);
            }
            else
            {
                
                empService.Add(emp);
            }
            MessageBox.Show(SysConst.msgSaveSuccess);
            empForm.listRefresh();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editFlag)
            {
                DialogResult result = MessageBox.Show(SysConst.msgDataChange, SysConst.msgBoxTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;  //点击OK  
                }
                else if (result == DialogResult.No)
                {
                    editFlag = false;
                    btnExit_Click(sender, e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BusinessControl.ClearControlValue(tpControl);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_rowindex == _ds.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                _rowindex++;
                InitBillFormContent(_rowindex);
            }
        }


        private void btnPre_Click(object sender, EventArgs e)
        {
            if (_rowindex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                _rowindex--;
                InitBillFormContent(_rowindex);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_rowindex == _ds.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                _rowindex = _ds.Count - 1;
                InitBillFormContent(_rowindex);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_rowindex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                _rowindex = 0;
                InitBillFormContent(_rowindex);
            }
        }
    }
}
