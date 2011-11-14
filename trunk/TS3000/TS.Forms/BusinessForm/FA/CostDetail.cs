using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Business.FA.Info;
using TS.Business.FA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Util;
using TS.Sys.Widgets.Refer.Control;
using TS.Sys.Widgets.Refer.Fetcher.Refer.Impl;

namespace TS.Forms.BusinessForm.FA
{
    public partial class CostDetailForm : BillTypeForm,IFormPointCut
    {
        private FaCostService fcService;
        private CostListForm fcForm;
        private FaCostInfo fi;
        private FaCostSubInfo fsi;
        private string _referType;
        private Object[] _args;
        private DataFetcher _dataFetcher; 
       

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
            FormPoint = this;
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
            con.Add("SumGrid", this.dgAmtTypeSum);
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
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = tempAssembly.GetType(this._referType);
            object[] args = this._args;
            object o = System.Activator.CreateInstance(t, args);

            ((Form)o).WindowState = FormWindowState.Normal;
            ((Form)o).ShowDialog();
        }

        private void ListRefresh()
        {
            fcForm.listRefresh(); 
        } 

        private void dgFaType_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            InitSumGrid();


        }

        private void InitSumGrid()
        {
            Hashtable result = Caculate();
            if (result != null && result.Count == 0)
                return;

            foreach (String key in result.Keys)
            {
                int index = 0;
                foreach (DataGridViewRow row in this.dgAmtTypeSum.Rows)
                {

                    if (row.Cells["CostType"].Value.Equals(key + "："))
                    {
                        row.Cells["TypeSum"].Value = result[key];
                        break;
                    }
                    index++;

                }
                if (dgAmtTypeSum.Rows.Count == 0 || index == dgAmtTypeSum.Rows.Count)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    Object[] values = new Object[] { key + "：", result[key] };
                    dgAmtTypeSum.Rows.Add(values);
                }

            }
            dgAmtTypeSum.ClearSelection();
        }


        private Hashtable Caculate()
        {
            Hashtable result = new Hashtable();
            Decimal amtSum = new Decimal();
            foreach (DataGridViewRow row in this.dgFaType.Rows)
            {

                DataGridViewCell prePayAmtCell = row.Cells["iPayAmt"];
                DataGridViewCell preCostTypeCell = row.Cells["cCostType"];
                if (prePayAmtCell.Value != null && preCostTypeCell.Value != null && !String.IsNullOrEmpty(prePayAmtCell.Value.ToString()) && !String.IsNullOrEmpty(preCostTypeCell.Value.ToString()))
                {
                    if (result[preCostTypeCell.Value] == null)
                    {
                        result.Add(preCostTypeCell.Value, NumberUtil.FormatAMT(prePayAmtCell.Value));
                    }
                    else
                    {
                        Decimal amt = NumberUtil.GetAmt(result[preCostTypeCell.Value].ToString());
                        amt += Decimal.Parse(prePayAmtCell.Value.ToString());
                        result[preCostTypeCell.Value] = NumberUtil.FormatAMT(amt);

                    }
                    amtSum += NumberUtil.GetAmt(result[preCostTypeCell.Value].ToString());
                }
                else
                {
                    continue;
                }

            }
            AmtSum.Text = NumberUtil.FormatAMT(amtSum);


            return result;
        }

        private void dgFaType_Leave(object sender, EventArgs e)
        {
            InitSumGrid();
        }


        public void doAfterLoad()
        {
            InitSumGrid();
        }
    }
}
