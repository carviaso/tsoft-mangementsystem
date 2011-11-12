using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Util;
using TS.Sys.Domain;
using System.Drawing;

namespace TS.Sys.Platform.Business.Forms
{
    public partial class BillTypeForm:DefaultForm,IFormEvents
    {

        private BusinessMainInfo _mainInfo;
        private AbstractBusinessService _businessService;
      
        //单据子表对象
        private BusinessSubInfo _subInfo;        
        //子表
        private DataGridView _subGrid;

        private string _billType;         
       
        public BillTypeForm()
        {
            InitButton();
            Items = this._toolBtn;
        }
                
        /// <summary>
        /// 初始化Form
        /// 需要构造参数
        /// ToolBtn，TpControl，MainInfo，Service，SubGrid
        /// </summary>
        /// <param name="con"></param>
        public void InitForm(Hashtable con)
        {
            base.InitForm(con);
            if (con["Info"] == null)
            {
                throw new BusinessException("MainInfo属性未设置");
            }
            if (con["Service"] == null)
            {
                throw new BusinessException("Service属性未设置");
            }
            if (con["SubGrid"] == null)
            {
                throw new BusinessException("SubGrid属性未设置");
            }
            else if (con["BillType"] == null)
            {
                throw new BusinessException("BillType属性未设置");
            }
            info = (BusinessMainInfo)con["Info"];
            service = (AbstractBusinessService)con["Service"];
            _businessService = (AbstractBusinessService)con["Service"];
            _mainInfo = (BusinessMainInfo)con["Info"];
            _subInfo = (BusinessSubInfo)con["SubInfo"];
            _subGrid = (DataGridView)con["SubGrid"];
            _billType = con["BillType"].ToString();
            this.FormEvents = this;
            //如果有子表则添加子表的事件
            if (_subGrid != null)
            {
                BindGridEvent();
            }

        }

        /// <summary>
        /// 新增时候触发
        /// </summary>
        public void InitForm()
        {
            base.InitForm();
        }

        /// <summary>
        /// 查看时候触发
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="ds"></param>
        public void InitForm(int rowIndex, DataGridViewRowCollection ds)
        {
            base.InitForm(rowIndex,ds);            
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
        public override void  InitBillFormContent(int rowIndex)
        {
            base.InitBillFormContent(rowIndex);
            DataGridViewRow r = dgRowCollection[rowIndex];
            Object cGUID = r.Cells["cGUID"].Value;
            //如果存在子表信息，给子表赋值
            if (_subGrid != null)
            {
                ArrayList subResult = _businessService.GetSubResult(cGUID);
                SetSubContent(subResult, _subGrid);                
            }
            tpControl.Enabled = (_mainInfo.cAuditor == null);
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

        private ToolStripButton btnAudit;
        private ToolStripButton btnUnAudit;
        private ToolStripItem[] _toolBtn;
        private void InitButton()
        {
            btnAudit = new System.Windows.Forms.ToolStripButton();
            btnUnAudit = new System.Windows.Forms.ToolStripButton();
            _toolBtn = new ToolStripItem[]{ 
            btnAudit,
            btnUnAudit};

            // 
            // btnAudit
            // 
            btnAudit.Image = global::TS.Sys.Platform.Business.Properties.Resources.auditor;
            btnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new System.Drawing.Size(36, 42);
            btnAudit.Text = "审核";
            btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAudit.Click += new EventHandler(btnAudit_Click);
            // 
            // btnUnAudit
            // 
            btnUnAudit.Image = global::TS.Sys.Platform.Business.Properties.Resources.unauditor;
            btnUnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnUnAudit.Name = "btnUnAudit";
            btnUnAudit.Size = new System.Drawing.Size(48, 42);
            btnUnAudit.Text = "反审核";
            btnUnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnUnAudit.Click += new EventHandler(btnUnAudit_Click);

        }

        /// <summary>
        /// 绘制行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.RowHeadersVisible)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);
                rect.Inflate(-2, -2);
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, rect, e.InheritedRowStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
            }
        }

        /// <summary>
        /// 数字列右对齐，否则左对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            //假设vista()方法是验证是否为数字的
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else if (e.RowIndex != -1 && e.ColumnIndex != 1)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

        }

        public void New()
        {
            String code = BusinessKey.GetBusinessKey().GetBusinessCode(_billType, 3);
            BusinessControl.SetNewValue(code, tpControl);
        }

        public void Add()
        {
            //添加明细信息
            if (_subGrid != null)
            {
                ArrayList subList = new ArrayList();
                foreach (DataGridViewRow r in _subGrid.Rows)
                {

                    if (r.Cells[0].Value != null)
                    {
                        BusinessControl.SetSubInfoProperties(_subInfo, r);
                        subList.Add(_subInfo);
                    }

                }
                _mainInfo.SubInfos = subList;
            }
            _businessService.DoModify(_mainInfo);
        }

        public void Modify()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            _businessService.DoDel(_mainInfo);
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            _businessService.DoAudit(_mainInfo);

            BusinessControl.SetControlValue(_mainInfo, tpControl);
            MessageBox.Show("单据[" + _mainInfo.cCode + "]" + SysConst.msgAuditSuccess, SysConst.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
            tpControl.Enabled = false; 
        }

        private void btnUnAudit_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            _businessService.DoUnAudit(_mainInfo);
            BusinessControl.SetControlValue(_mainInfo, tpControl);

            MessageBox.Show("单据[" + _mainInfo.cCode + "]" + SysConst.msgUnAuditSuccess, SysConst.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
            tpControl.Enabled = true;

        }
    }
}
