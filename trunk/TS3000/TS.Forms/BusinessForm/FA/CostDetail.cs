using System;
using System.Collections;
using System.Windows.Forms;
using TS.Business.FA.Info;
using TS.Business.FA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Widgets.Refer.Control;
using TS.Sys.Widgets.Refer.Fetcher.Refer.Impl;
using System.Data;
using TS.Sys.Widgets.Refer.GridRefer;
using TS.Sys.Domain;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Widgets.Money.GridMoney;
using TS.Sys.Widgets;
using TS.Sys.Util;

namespace TS.Forms.BusinessForm.FA
{
    public partial class CostDetailForm : BillTypeForm
    {
        private FaCostService fcService;
        private CostListForm fcForm;
        private FaCostInfo fi;
        private FaCostSubInfo fsi;
        private string _referType;
        private Object[] _args;
        private DataFetcher _dataFetcher;
        private TableLayoutPanel payDetail;
       

        internal CostListForm FcForm
        {
            set { this.fcForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public CostDetailForm()
        {
            InitializeComponent(); 
            fcService = new FaCostService();
            fi = new FaCostInfo();
            fsi = new FaCostSubInfo();
            FaTypeReferImpl tyRml = new FaTypeReferImpl();
            _dataFetcher = new DataFetcher("CM_FaType");
            tyRml.Grid = this.dgFaType;
            tyRml.setGridDataSource(this.cCostType, null);
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolCostDetail);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", fi);
            con.Add("SubInfo", fsi);
            con.Add("Service", fcService);
            con.Add("SubGrid", this.dgFaType);
            con.Add("BillType", "FC");
            InitForm(con);
             
        }

        public CostDetailForm(String action)
            :this()
        {
            InitForm();
        }

        public CostDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex,ds);
        }

        private void btnInfo_Click()
        {
            
        }

        private void ListRefresh()
        {
            fcForm.listRefresh(); 
        }

        private void dgFaType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgFaType_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                
                int preRow = e.RowIndex - 1;
                if (preRow >= 0)
                {
                    DataGridViewCell prePayAmtCell = this.dgFaType.Rows[preRow].Cells["iPayAmt"];
                    DataGridViewCell preCostTypeCell = this.dgFaType.Rows[preRow].Cells["cCostType"];
                    if (prePayAmtCell.Value != null && preCostTypeCell.Value != null)
                    {

                        if (payDetail == null)
                        {


                            this.payDetail = new System.Windows.Forms.TableLayoutPanel();
                            payDetail.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                            payDetail.Height = 30;
                            this.payDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
                            payDetail.RowCount = 1;
                            payDetail.ColumnCount = 2;
                            this.payDetail.Location = new System.Drawing.Point(14, 63);
                            this.payDetail.Size = new System.Drawing.Size(250, 62);
                            this.payDetail.TabIndex = 2;
                            this.payDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
                            this.payDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                            this.payDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                            Label costType = new Label();
                            costType.Name = preCostTypeCell.Value.ToString();
                            costType.Text = preCostTypeCell.Value.ToString() + "：";
                            costType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                            Label payAmt = new Label();
                            payAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                            payAmt.Name = preCostTypeCell.Value.ToString() + "_value";
                            payAmt.Text = prePayAmtCell.Value.ToString();
                            payDetail.Controls.Add(costType, 0, 0);
                            payDetail.Controls.Add(payAmt, 1, 0);
                            this.tableLayoutPanel3.Controls.Add(this.payDetail, 0, 1);
                        }
                        else
                        {
                            Control c = this.payDetail.Controls[preCostTypeCell.Value.ToString()];
                            if (c != null)
                            {
                                Control o = this.payDetail.Controls[preCostTypeCell.Value.ToString() + "_value"];
                                Decimal preNum = NumberUtil.GetAmt(((Label)o).Text);
                                Decimal curNum = Decimal.Parse(prePayAmtCell.Value.ToString());
                                Decimal sum = preNum+curNum;
                                ((Label)o).Text = "￥" + sum.ToString();
                            }
                            else
                            {
                                payDetail.Height += 30;
                                payDetail.RowCount++;
                                this.payDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                                Label costType = new Label();
                                costType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                                costType.Name = preCostTypeCell.Value.ToString();
                                costType.Text = preCostTypeCell.Value.ToString() + "：";
                                Label payAmt = new Label();
                                payAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                                payAmt.Name = preCostTypeCell.Value.ToString() + "_value";
                                payAmt.Text = prePayAmtCell.Value.ToString();
                                payDetail.Controls.Add(costType, 0, payDetail.RowCount - 1);
                                payDetail.Controls.Add(payAmt, 1, payDetail.RowCount - 1);
                            }
                        }
                    }
                }
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgFaType_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = this.dgFaType.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewCell costTypeCell = this.dgFaType.Rows[e.RowIndex].Cells["cCostType"];
            if (cell is DataGridViewMoneyCell)
            {
                object o = cell.Value;
                object b = cell.FormattedValue;
            }
        }
         

       
         
    }
}
