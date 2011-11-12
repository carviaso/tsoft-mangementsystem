using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class RegionDetailForm : Form
    {
        private bool editFlag = false;
        private RegionService rgService;
        private RegionInfo rgInfo;
        private RegionForm _rgForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;

        public RegionDetailForm()
        {
            InitializeComponent();
            rgService = new RegionService();
        }

        internal RegionForm RgForm
        {
            set { this._rgForm = value; }
        }

        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public RegionDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            _rowindex = rowIndex;
            this._ds = ds;           
            InitBillFormContent(rowIndex);
        }
         
        private void InitBillFormContent(int rowIndex)
        {
             
            DataGridViewRow r = _ds[rowIndex]; 
            Object cGUID = r.Cells["cGUID"].Value;
            //ArrayList mainResult = rgService.GetResultByGUID(cGUID);
            //BillForm.SetMainContent(rgInfo, mainResult, tpControl);  
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BusinessControl.ClearControlValue(tpControl);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAction();
            btnSave.Enabled = false;
        }

        private void saveAction()
        {

            RegionInfo ri = new RegionInfo();
            ri.cCode = cCode.Value;
            ri.cName = cName.Value; 
            ri.iForbidden = 0;
            if (cGUID.Value != null && String.IsNullOrEmpty((string)cGUID.Value))
            {
                ri.cGUID = cGUID.Value;
                rgService.Modify(ri);
            }
            else
            {
                rgService.Add(ri);
            }
            MessageBox.Show("保存成功！");
            _rgForm.listRefresh();

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
    }
}
