using System;
using System.Data;
using System.Windows.Forms;
using TS.Business.FA.Info;
using TS.Business.FA.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;

namespace TS.Sys.Platform.Forms.BusinessForm.FA
{
    public partial class CostListForm : Form
    {
        private FaCostService fcService;
        private FaCostInfo fcInfo;
        public CostListForm()
        {
            InitializeComponent();
            fcService = new FaCostService();
            fcInfo = new FaCostInfo();
            InitGrid();
             
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null);            
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher();
            
            gridFaCost.Columns["cCode"].HeaderText = "单据编号";
            gridFaCost.Columns["cCode"].Frozen = true; 
            gridFaCost.Columns["dDate"].HeaderText = "单据日期";
            gridFaCost.Columns["cSupply"].HeaderText = "供应商";
            gridFaCost.Columns["cSettleAcct"].HeaderText = "结算科目";
            gridFaCost.Columns["cSettleType"].HeaderText = "结算方式";
            gridFaCost.Columns["cSettleCode"].HeaderText = "结算号";
            gridFaCost.Columns["iAmt"].HeaderText = "付款金额";
            gridFaCost.Columns["cBank"].HeaderText = "付款银行";
            gridFaCost.Columns["cBankAcct"].HeaderText = "银行账户";
            gridFaCost.Columns["cAuditStatus"].HeaderText = "审核状态";
            gridFaCost.Columns["cAuditor"].HeaderText = "审核人";
            gridFaCost.Columns["dAuditDate"].HeaderText = "审核日期";
            gridFaCost.Columns["cDepartment"].HeaderText = "部门";
            gridFaCost.Columns["cOperator"].HeaderText = "经手人";
            gridFaCost.Columns["cCreator"].HeaderText = "制单人";
            gridFaCost.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridFaCost.Columns["cTimeStamp"].Visible = false;
            gridFaCost.Columns["cGUID"].HeaderText = "编号";
            gridFaCost.Columns["cGUID"].Visible = false;
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            DataTable result = fcService.QueryForAll();
            gridFaCost.DataSource = result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridFaCost.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }

        private void gridFaCost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowCostDetailForm(e.RowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(fcInfo, this.gridFaCost);
            DialogResult diaResult = Msg.Show("是否删除单据[" + fcInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult == DialogResult.OK)
            {
                try
                {
                    fcService.DoDel(fcInfo);
                    Msg.Show(SysConst.msgDeleteSuccess);
                    btnRefresh_Click(sender, e);
                }
                catch (BusinessException ex)
                {
                    Msg.Show(ex.Message);
                }
                 
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

        private void btnAudit_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(fcInfo, this.gridFaCost);
            try
            {
                fcService.DoAudit(fcInfo);
                Msg.Show("单据[" + fcInfo.cCode + "]" + SysConst.msgAuditSuccess);
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnUnAudit_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(fcInfo, this.gridFaCost);
            try
            {
                fcService.DoUnAudit(fcInfo);
                Msg.Show("单据[" + fcInfo.cCode + "]" + SysConst.msgUnAuditSuccess);
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                CostDetailForm cdForm = new CostDetailForm((int)rowIndex, this.gridFaCost.Rows);
                cdForm.FcForm = this;
                cdForm.ShowDialog();
            }
            else
            {
                CostDetailForm cdForm = new CostDetailForm("new");
                cdForm.FcForm = this;
                cdForm.ShowDialog();
            }
        }      
    }
}
