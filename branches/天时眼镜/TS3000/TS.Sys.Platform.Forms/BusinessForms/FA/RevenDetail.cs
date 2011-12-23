using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Business.FA.Info;
using TS.Business.FA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Control;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;
using TS.Sys.Util;

namespace TS.Sys.Platform.Forms.BusinessForm.FA
{
    public partial class RevenDetailForm : BillTypeForm,IFormPointCut
    {
        private FaRevenService frService;
        private RevenListForm frForm;
        private FaRevenInfo frInfo; 
        private FaRevenSubInfo frsInfo; 
        private string _referType;
        private Object[] _args;
        private DataFetcher _dataFetcher; 


        internal RevenListForm FrForm
        {
            set { this.frForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public RevenDetailForm()
        {
            InitializeComponent();
            frService = new FaRevenService();
            frInfo = new FaRevenInfo();
            frsInfo = new FaRevenSubInfo();
            FormPoint = this;
            FaTypeReferImpl tyRml = new FaTypeReferImpl();
            _dataFetcher = new DataFetcher("CM_FaType");
            tyRml.Grid = this.dgFaType;
            tyRml.setGridDataSource(this.cRevenType, null); 
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolCostDetail);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", frInfo);
            con.Add("SubInfo", frsInfo);
            con.Add("Service", frService);
            con.Add("SubGrid", this.dgFaType);
            con.Add("BillType", "FR");
            con.Add("SumGrid", this.dgAmtTypeSum);
            InitForm(con);
            
        } 

         public RevenDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            frForm.listRefresh(); 
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

                    if (row.Cells["RevenType"].Value.Equals(key + "："))
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
                DataGridViewCell preCostTypeCell = row.Cells["cRevenType"];
                if (prePayAmtCell.Value != null && preCostTypeCell.Value != null)
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
            AmtSum.Text = NumberUtil.FormatAMT(amtSum.ToString());


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
