using System;
using System.Collections;
using System.Windows.Forms;
using TS.Business.FA.Info;
using TS.Business.FA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Widgets.Refer.Control;
using TS.Sys.Widgets.Refer.Fetcher.Refer.Impl;
using System.Data;

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
            con.Add("MainInfo", fi);
            con.Add("SubInfo", fsi);
            con.Add("Service", fcService);
            con.Add("SubGrid", this.dgFaType);
            con.Add("BillType", "FC");
            InitForm(con);
            gridSum.Rows.Add();
            
            DataTable afa = new DataTable();

            afa.Columns.Add("CostTypeName");
            afa.Columns.Add("AmtSum");

            afa.LoadDataRow(new string[] { "1003", "2" }, true);
            afa.LoadDataRow(new string[] { "1004", "3" }, true);
            gridSum.DataSource = afa;

            DataGridViewRow dgr = gridSum.Rows[gridSum.Rows.Count - 1];
            dgr.ReadOnly = true;
            dgr.DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
            dgr.Cells[0].Value = "合计";
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
         

       
         
    }
}
