using System;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Util;
using TS.Sys.Domain;
using TS.Sys.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class RegionForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private RegionService rgService;
        private RegionInfo rgInfo; 
        public RegionForm()
        {
            InitializeComponent();
            rgService = new RegionService();
            TreeNode root = new TreeNode("结算方式");
            root.Name = "000000";
            treeRegion.Nodes.Add(root);
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public RegionForm(LabelRefer refer)
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
        public RegionForm(DataGridView dg, int row, int col)
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
            GridFetcher();
            gridRegion.Columns["cGUID"].HeaderText = "编号";
            gridRegion.Columns["cGUID"].Visible = false;
            gridRegion.Columns["cCode"].HeaderText = "代码";
            gridRegion.Columns["cName"].HeaderText = "名称";
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            gridRegion.DataSource = rgService.QueryForAll();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridRegion.SelectedRows[0].Index;
            RegionDetailForm rgDetailForm = new RegionDetailForm(rowIndex, this.gridRegion.Rows);
            rgDetailForm.RgForm = this;
            rgDetailForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(rgInfo, this.gridRegion);
                rgService.DoDel(rgInfo);
                MessageBox.Show(SysConst.msgDeleteSuccess);
                btnRefresh_Click(sender, e);
            }  
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFetcher();
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(rgInfo, this.gridRegion);
                rgService.DoForbidden(rgInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
            } 
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgValueableConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(rgInfo, this.gridRegion);
                rgService.DoValueable(rgInfo);
                MessageBox.Show(SysConst.msgValueableSuccess);
            }  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RegionDetailForm rgDetailForm = new RegionDetailForm();
            rgDetailForm.RgForm = this;
            rgDetailForm.ShowDialog();
        }

        private void gridRegion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridRegion.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
    }
}
