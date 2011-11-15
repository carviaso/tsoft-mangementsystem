using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util;

namespace TS.Forms.BusinessForm.BS
{
    public partial class DepartmentDetailForm : Form
    {
        private bool editFlag = false;
        private DepartmentService deptService;
        private DepartmentInfo deptInfo;
        private DepartmentForm deptForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;

        public DepartmentDetailForm()
        {
            InitializeComponent();
            deptService = new DepartmentService();
            deptInfo = new DepartmentInfo();
            this.tbControl.TabPages[0].Text = "部门属性";
        }

        internal DepartmentForm DeptForm
        {
            set { this.deptForm = value; }
        }
        
        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public DepartmentDetailForm(DataGridView grid)
            : this()
        {
            _rowindex = grid.SelectedRows[0].Index;
            this._ds = grid.Rows;
            InitBillFormContent(_rowindex);
        }
         
        private void InitBillFormContent(int rowIndex)
        {
             
            DataGridViewRow r = _ds[rowIndex]; 
            Object cGUID = r.Cells["cGUID"].Value;
            this.tbControl.TabPages[0].Text = r.Cells["cName"].Value + "的属性";
            //ArrayList mainResult = deptService.GetResultByGUID(cGUID);
            //BillForm.SetMainContent(deptInfo, mainResult, tpControl);  
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            BusinessControl.ClearControlValue(tpControl);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAction();
            btnSave.Enabled = false;
           
        }

        private void saveAction()
        {
            BusinessControl.SetInfoProperties(deptInfo, tpControl);   
            if (cGUID.Value != null && !String.IsNullOrEmpty((string)cGUID.Value))
            {
                deptService.Modify(deptInfo);
            }
            else
            {
                deptService.Add(deptInfo);
            }
            MessageBox.Show(SysConst.msgSaveSuccess);
            deptForm.listRefresh();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingMethod(sender, e);
        }

        private void FormClosingMethod(object sender, FormClosingEventArgs e)
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
