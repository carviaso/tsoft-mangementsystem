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
    public partial class DepartmentForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private DepartmentService deptService;
        private DepartmentInfo deptInfo;
        public DepartmentForm()
        {
            InitializeComponent();
            deptService = new DepartmentService();
            deptInfo = new DepartmentInfo();
            this.treeDepartment.loadTreeDataByTable("部门");
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public DepartmentForm(LabelRefer refer)
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
        public DepartmentForm(DataGridView dg, int row, int col)
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
            gridDepartment.Columns["cGUID"].Visible = false;
            gridDepartment.Columns["cCode"].HeaderText = "编码";
            gridDepartment.Columns["cName"].HeaderText = "名称";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(deptInfo, this.gridDepartment); 
                deptService.DoDel(deptInfo);
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
            treeDepartment_AfterTreeNodeSelect(null, null);
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (diaResult == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(deptInfo, this.gridDepartment);
                 deptService.DoForbidden(deptInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
            }
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgValueableConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(deptInfo, this.gridDepartment);
                deptService.DoValueable(deptInfo);
                MessageBox.Show(SysConst.msgValueableSuccess);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DepartmentDetailForm deptDetailForm = new DepartmentDetailForm(this.gridDepartment);
            deptDetailForm.DeptForm = this;
            deptDetailForm.ShowDialog(); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DepartmentDetailForm custDetailForm = new DepartmentDetailForm();
            custDetailForm.DeptForm = this;
            custDetailForm.ShowDialog(); 
        }

        private void gridDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridDepartment.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
         

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridDepartment.DataSource = deptService.QueryTreeResult(con);
        }

        private void treeDepartment_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            string cGUID = treeDepartment.GetSelectedNode().Name;
            GridFetcher(cGUID);
        }

         
    }
}
