using System;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Util;
using TS.Sys.Platform.BaseData.Info; 
using TS.Sys.Widgets.Refer.WidgetRefer;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;

namespace TS.Forms.BusinessForm.BS
{
    public partial class CustomerForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private CustomerService custService;
        private CustomerInfo custInfo;
        public CustomerForm()
        {
            InitializeComponent();
            custService = new CustomerService();
            custInfo = new CustomerInfo();
            this.treeRegion.loadTreeDataByTable("地区");
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public CustomerForm(LabelRefer refer)
            : this()
        {
            _referFlag = 1;
            this._refer = refer;
        }


        /// <summary>
        /// 由列表弹出
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public CustomerForm(DataGridView dg, int row, int col)
            : this()
        {
            _referFlag = 2;
            _dg = dg;
            _row = row;
            _col = col;
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher(null);
            gridCustomer.Columns["cGUID"].HeaderText = "编号";
            gridCustomer.Columns["cGUID"].Visible = false;
            gridCustomer.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridCustomer.Columns["cTimeStamp"].Visible = false;
            gridCustomer.Columns["cCode"].HeaderText = "代码";
            gridCustomer.Columns["cName"].HeaderText = "名称";
            gridCustomer.Columns["cRegion"].HeaderText = "所属地区";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new CustomerDetailForm().ShowDialog();
            CustomerDetailForm custDetailForm = new CustomerDetailForm();
            custDetailForm.cRegionValue = treeRegion.GetSelectedNode().Name;
            custDetailForm.CustForm = this;
            custDetailForm.ShowDialog(); 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            CustomerDetailForm custDetailForm = new CustomerDetailForm(this.gridCustomer);
            custDetailForm.CustForm = this;
            custDetailForm.ShowDialog(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(custInfo, this.gridCustomer);
                custService.DoDel(custInfo);
                MessageBox.Show(SysConst.msgDeleteSuccess);
                btnRefresh_Click(sender, e);
            } 
            
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null,null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeRegion_AfterTreeNodeSelect(null, null);
        }

       
        private void btnForbidden_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(custInfo, this.gridCustomer);
                custService.DoForbidden(custInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
            }  
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgValueableConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(custInfo, this.gridCustomer);
                custService.DoValueable(custInfo);
                MessageBox.Show(SysConst.msgValueableSuccess);
            }  

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridCustomer.DataSource = custService.QueryByRegion(con);
        }

        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridCustomer.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
                if (_referFlag == 1)
                {
                    _refer.Value = value;
                }
                else
                {
                    _dg[_col, _row].Value = value;
                }
                this.Close();
            }
            else
            {
                btnView_Click(null, null);
            }
        } 

        private void treeRegion_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            string cGUID = treeRegion.GetSelectedNode().Name;
            if ("000000".Equals(cGUID))
            {
                GridFetcher(null);
            }
            else
            {
                GridFetcher(cGUID);
            }
        }
    }
}
