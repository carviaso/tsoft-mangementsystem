using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Business.FA.Info;
using TS.Business.FA.Service; 
using TS.Sys.Widgets.Refer.Fetcher.Refer.Impl;
using TS.Sys.Platform.Business.Forms;

namespace TS.Forms.BusinessForm.FA
{
    public partial class RevenDetailForm : BillTypeForm
    {
        private FaRevenService frService;
        private RevenListForm frForm;
        private FaRevenInfo frInfo;
        private FaRevenSubInfo frsInfo; 
        private string _referType;
        private Object[] _args;


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
            new FaTypeReferImpl().setGridDataSource(this.cRevenType, null);
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolCostDetail);
            con.Add("TpControl", this.tpControl);
            con.Add("MainInfo", frInfo);
            con.Add("SubInfo", frsInfo);
            con.Add("Service", frService);
            con.Add("SubGrid", this.dgFaType);
            con.Add("BillType", "FR");
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
         
    }
}
