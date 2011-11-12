using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Widgets.Refer.WidgetRefer;

namespace TS.Sys.Platform.Business.Forms
{
    public partial class BillTypeForm:DefaultForm
    {
         
        
      
        //单据子表对象
        private BusinessSubInfo _subInfo;        
        //子表
        private DataGridView _subGrid;

        private string _billType;         
       
        public BillTypeForm()
        { }
                
        /// <summary>
        /// 初始化Form
        /// 需要构造参数
        /// ToolBtn，TpControl，MainInfo，Service，SubGrid
        /// </summary>
        /// <param name="con"></param>
        public void InitForm(Hashtable con)
        {
            
            if (con["Info"] == null)
            {
                MessageBox.Show("MainInfo属性未设置");
            }
            else if (con["Service"] == null)
            {
                MessageBox.Show("Service属性未设置");
            }
            else if (con["SubGrid"] == null)
            {
                MessageBox.Show("SubGrid属性未设置");
            }
            else if (con["BillType"] == null)
            {
                MessageBox.Show("BillType属性未设置");
            }
            _toolBtn = (ToolStrip)con["ToolBtn"];
            _tpControl = (TableLayoutPanel)con["TpControl"];
            _mainInfo = (BusinessMainInfo)con["MainInfo"];
            _subInfo = (BusinessSubInfo)con["SubInfo"];
            _service = (AbstractBusinessService)con["Service"];
            _subGrid = (DataGridView)con["SubGrid"];
            _billType = con["BillType"].ToString();
            if (_tpControl != null)
            {
                InitButton();
                
                ReferSetInfoStatus(this, btnInfo, _tpControl);
                if (_subGrid != null)
                {
                    BindGridEvent();
                }
            }
        }

        /// <summary>
        /// 新增时候触发
        /// </summary>
        public void InitForm()
        {
            btnNew_Click(null, null);
        }

        /// <summary>
        /// 查看时候触发
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="ds"></param>
        public void InitForm(int rowIndex, DataGridViewRowCollection ds)
        {            
            _ds = ds;
            _rowindex = rowIndex;
            if (_ds != null)
            {
                InitBillFormContent(_rowindex);                
            }
            
        }

        /// <summary>
        /// 列表事件绑定
        /// </summary>
        private void BindGridEvent()
        {
            _subGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(datagrid_RowPostPaint);
            _subGrid.CellPainting += new DataGridViewCellPaintingEventHandler(datagrid_CellPainting); 
        } 

        /// <summary>
        /// 初始化单据
        /// </summary>
        /// <param name="rowIndex"></param>
        public void InitBillFormContent(int rowIndex)
        {
            DataGridViewRow r = _ds[rowIndex];
            Object cGUID = r.Cells["cGUID"].Value;
            ArrayList mainResult = _service.GetMainResult(cGUID);
            if (mainResult.Count > 0)
            {
                SetMainContent(_mainInfo, (Hashtable)mainResult[0], _tpControl);
            }
            //如果存在子表信息，给子表赋值
            if (_subGrid != null)
            {
                ArrayList subResult = _service.GetSubResult(cGUID);
                SetSubContent(subResult, _subGrid);                
            }
            _tpControl.Enabled = (_mainInfo.cAuditor == null);
        }
 

        /// <summary>
        /// 设置参照控件的坐标变换事件
        /// </summary>
        /// <param name="tpControl"></param>
        public static void ReferSetInfoStatus(Form f,ToolStripButton btn, TableLayoutPanel tpControl)
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();
            Type t = tempAssembly.GetType("TS.Sys.Platform.Business.Forms.BillTypeForm");
            Form o = (Form)System.Activator.CreateInstance(t, null);
            foreach (Control control in tpControl.Controls)
            {
                if (control is LabelRefer)
                {
                    ((LabelRefer)control).SetInfoStatus(f,o, btn); 
                } 
            }
        }


        /// <summary>
        /// 设置主表值
        /// </summary>
        /// <param name="info"></param>
        /// <param name="infoDetail"></param>
        /// <param name="tpControl"></param>
        private void SetMainContent(Object info, Hashtable infoDetail, TableLayoutPanel tpControl)
        {

            foreach (String key in infoDetail.Keys)
            {
                if (tpControl.Controls.ContainsKey(key))
                {
                    Control control = tpControl.Controls[key];
                    BusinessControl.SetComValue(control, infoDetail[key].ToString());
                    BusinessControl.SetInfoProperties(info, tpControl);
                }
            }
        }

        /// <summary>
        /// 设置子表值
        /// </summary>
        /// <param name="resultSub"></param>
        /// <param name="grid"></param>
        public static void SetSubContent(ArrayList result, DataGridView grid)
        {
            grid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                Hashtable detail = (Hashtable)result[i];
                Object[] cellValues = new Object[detail.Count];
                int index = 0;
                foreach (String key in detail.Keys)
                {
                    if (key.Equals("cGUID") || key.Equals("cHeadGUID") || key.Equals("cTimeStamp"))
                    {
                        continue;
                    }
                    Object value = detail[key]; 
                    cellValues[index] = value;
                    index++;
                }
                grid.Rows.Add(cellValues);
            }
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            if (_tpControl == null)
                return;
            foreach (Control control in _tpControl.Controls)
            {
                if (control is LabelRefer)
                {
                    ((LabelRefer)control).LocationChange();
                }
            }
        }
        
    }
}
