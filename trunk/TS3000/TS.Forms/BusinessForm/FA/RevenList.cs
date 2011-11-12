using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using TS.Business.FA.Service;
using TS.Sys.Domain;
using TS.Sys.Util;
using TS.Business.FA.Info;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.FA
{
    public partial class RevenListForm : Form
    {
        private FaRevenService frService;
        private FaRevenInfo frInfo;
        public RevenListForm()
        {
            InitializeComponent();
            frService = new FaRevenService();
            frInfo = new FaRevenInfo();
            InitGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null); 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridFaReven.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(frInfo, this.gridFaReven);
            DialogResult diaResult = MessageBox.Show("是否删除单据[" + frInfo.cCode + "]？", SysConst.msgDeleteConfirm, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult == DialogResult.OK)
            {
                Result operResult = frService.DoDel(frInfo);
                MessageBox.Show(SysConst.msgDeleteSuccess);
                btnRefresh_Click(sender, e);
            }
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFetcher();
        }
 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher();

            gridFaReven.Columns["cCode"].HeaderText = "单据编号";
            gridFaReven.Columns["cCode"].Frozen = true;
            gridFaReven.Columns["dDate"].HeaderText = "单据日期";
            gridFaReven.Columns["cCustomer"].HeaderText = "客户";
            gridFaReven.Columns["cSettleAcct"].HeaderText = "结算科目";
            gridFaReven.Columns["cSettleType"].HeaderText = "结算方式";
            gridFaReven.Columns["cSettleCode"].HeaderText = "结算号";
            gridFaReven.Columns["iAmt"].HeaderText = "收款金额";
            gridFaReven.Columns["cBank"].HeaderText = "收款银行";
            gridFaReven.Columns["cBankAcct"].HeaderText = "银行账户";
            gridFaReven.Columns["cAuditStatus"].HeaderText = "审核状态";
            gridFaReven.Columns["cAuditor"].HeaderText = "审核人";
            gridFaReven.Columns["dAuditDate"].HeaderText = "审核日期";
            gridFaReven.Columns["cDepartment"].HeaderText = "部门";
            gridFaReven.Columns["cOperator"].HeaderText = "经手人";
            gridFaReven.Columns["cCreator"].HeaderText = "制单人";

            gridFaReven.Columns["cGUID"].HeaderText = "编号";
            gridFaReven.Columns["cGUID"].Visible = false;
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            DataTable result = frService.QueryForAll();
            gridFaReven.DataSource = result;
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(frInfo, this.gridFaReven);
            frService.DoAudit(frInfo);
            MessageBox.Show("单据[" + frInfo.cCode + "]" + SysConst.msgAuditSuccess, SysConst.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnUnAudit_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(frInfo, this.gridFaReven); 
            frService.UnAudit(frInfo);
            MessageBox.Show("单据[" + frInfo.cCode + "]" + SysConst.msgUnAuditSuccess, SysConst.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void gridFaReven_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowCostDetailForm(e.RowIndex);
            } 
        }

        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                RevenDetailForm rdForm = new RevenDetailForm((int)rowIndex, this.gridFaReven.Rows);
                rdForm.FrForm = this;
                rdForm.ShowDialog();
            }
            else
            {
                RevenDetailForm rdForm = new RevenDetailForm();
                rdForm.FrForm = this;
                rdForm.ShowDialog();
            }
        }    
    }
}
