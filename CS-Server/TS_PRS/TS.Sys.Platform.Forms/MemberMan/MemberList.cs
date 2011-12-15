using System;
using System.Data;
using System.Windows.Forms;
using TS.PRS.MemberMan.Info;
using TS.PRS.MemberMan.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer; 

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberListForm : Form
    {
        private LabelRefer _refer; 
        private int _referFlag;
        private MembersService mbService;
        private MembersInfo mbInfo;
        public MemberListForm()
        {
            InitializeComponent();
            mbService = new MembersService();
            mbInfo = new MembersInfo();
            InitGrid();
             
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public MemberListForm(LabelRefer refer)
            : this()
        {
            _referFlag = 1;
            this._refer = refer;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ShowCostDetailForm(null);
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }
         
        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher();
            
            gridMember.Columns["cCode"].HeaderText = "会员编号";
            gridMember.Columns["cName"].HeaderText = "会员名称";
            gridMember.Columns["cName"].Frozen = true;
            gridMember.Columns["cId"].HeaderText = "身份证号";
            gridMember.Columns["dRecommendDate"].HeaderText = "推荐时间";
            gridMember.Columns["cCompany"].HeaderText = "任职公司";
            gridMember.Columns["cRecomm"].HeaderText = "推荐人";
            gridMember.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridMember.Columns["cTimeStamp"].Visible = false;
            gridMember.Columns["cGUID"].HeaderText = "编号";
            gridMember.Columns["cGUID"].Visible = false;
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            DataTable result = mbService.GetDataTable(null);
            gridMember.DataSource = result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridMember.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }

        private void gridMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (_refer != null)
            {
                String value = this.gridMember.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
                if (_referFlag == 1)
                {
                    _refer.Value = value;
                } 
                this.Close();
            }
            else
            {
                btnView_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //鉴权
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                BusinessControl.SetInfoByGrid(mbInfo, this.gridMember);
                DialogResult diaResult = Msg.Show("是否删除[" + mbInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {
                    mbService.DoDel(mbInfo);
                    Msg.Show(SysConst.msgDeleteSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
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

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                MemberDetailForm mbForm = new MemberDetailForm((int)rowIndex, this.gridMember.Rows);
                mbForm.MemberlistForm = this;
                mbForm.ShowDialog();
            }
            else
            {
                MemberDetailForm mbForm = new MemberDetailForm("new");
                mbForm.MemberlistForm = this;
                mbForm.ShowDialog();
            }
        } 
    }
}
