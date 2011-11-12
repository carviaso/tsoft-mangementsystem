using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info; 
using TS.Sys.PlatForm.BaseData.Service;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class AccountDetailForm : Form
    {
        private bool editFlag = false;
        private AccountService acctService;
        private AccountForm _accForm;
        private AccountInfo acctInfo;
        private int _rowindex; 
        private DataGridViewRowCollection _ds;

        public AccountDetailForm()
        {
            InitializeComponent();
            acctService = new AccountService();
            acctInfo = new AccountInfo();
            
        }

        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public AccountDetailForm(DataGridView grid)
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
            //ArrayList mainResult = acctService.GetResultByGUID(cGUID);
            //BillForm.SetMainContent(acctInfo, mainResult, tpControl);  
        }

        internal AccountForm AccForm
        {
            set { this._accForm = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setSaveEnabled()
        {
            this.btnSave.Enabled = true;
            this.editFlag = true;
        }

        private void AccountDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editFlag)
            {
                DialogResult result = MessageBox.Show(SysConst.msgDataChange,SysConst.msgBoxTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
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
 

        private void ednAcctCode_TextBoxKeyPress(object sender, EventArgs e)
        {
            setSaveEnabled();
        }

        private void ednAcctName_TextBoxKeyPress(object sender, EventArgs e)
        {
            setSaveEnabled();
        }

        private void ednAcctShortCode_TextBoxKeyPress(object sender, EventArgs e)
        {
            setSaveEnabled();
        }

        private void cmbAcctType_ComboxSelectedValueChanged(object sender, EventArgs e)
        {
            setSaveEnabled();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountInfo accInfo = new AccountInfo();
            //构造fi
            BusinessControl.SetInfoProperties(accInfo,tpControl);
            if (cGUID.Value != null && cGUID.Value.ToString() != "")
            {
                acctService.DoModify(accInfo);
            }
            else
            {
                acctService.DoAdd(accInfo);
            }
            MessageBox.Show(SysConst.msgSaveSuccess);
            _accForm.listRefresh();
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
