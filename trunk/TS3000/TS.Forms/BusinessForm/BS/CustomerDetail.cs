using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class CustomerDetailForm : Form
    {
        private CustomerService custService;
        private CustomerInfo custInfo;
        private CustomerForm custForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;
        public CustomerDetailForm()
        {
            InitializeComponent();
            custService = new CustomerService();
            custInfo = new CustomerInfo();
            this.tbControl.TabPages[0].Text = "客户属性";
        }

        internal CustomerForm CustForm
        {
            set { this.custForm = value; }
        }

        internal String cRegionValue
        {
            get { return this.cRegion.Value.ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.Equals("000000"))
                { this.cRegion.Value = value; }
            }
        }

       /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public CustomerDetailForm(DataGridView grid)
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
            //ArrayList mainResult = custService.GetResultByGUID(cGUID);
            //BillForm.SetMainContent(custInfo, mainResult, tpControl);  
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //构造fi
            BusinessControl.SetInfoProperties(custInfo, tpControl);
            if (cGUID.Value != null && cGUID.Value.ToString() != "")
            {
                custService.Modify(custInfo);
            }
            else
            {
                custService.Add(custInfo);
            }
            MessageBox.Show(SysConst.msgSaveSuccess);
            custForm.listRefresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CustomerDetailForm_Move(object sender, EventArgs e)
        {

        }
    }
}
