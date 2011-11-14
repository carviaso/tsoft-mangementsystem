namespace TS.Forms.BusinessForm.FA
{
    partial class CostDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolCostDetail = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cSupply = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cSettleAcct = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cSettleType = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cCode = new TS.Sys.Widgets.LabelEdit();
            this.dDate = new TS.Sys.Widgets.LabelDateTime();
            this.cSettleCode = new TS.Sys.Widgets.LabelEdit();
            this.cOperator = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cDepartment = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cAuditor = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cCreator = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cRemark = new TS.Sys.Widgets.LabelEdit();
            this.dgFaType = new System.Windows.Forms.DataGridView();
            this.cCostType = new TS.Sys.Widgets.Refer.GridRefer.DataGridViewDataControlColumn();
            this.iPayAmt = new TS.Sys.Widgets.Money.GridMoney.DataGridViewMoneyColumn();
            this.cSubRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGUID = new TS.Sys.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Widgets.LabelEdit();
            this.dAuditDate = new TS.Sys.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cBankAcct = new TS.Sys.Widgets.LabelEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AmtSum = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgAmtTypeSum = new System.Windows.Forms.DataGridView();
            this.CostType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label3_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label5_value = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaType)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmtTypeSum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolCostDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 674);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolCostDetail
            // 
            this.toolCostDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolCostDetail.Location = new System.Drawing.Point(1, 1);
            this.toolCostDetail.Name = "toolCostDetail";
            this.toolCostDetail.Size = new System.Drawing.Size(1014, 45);
            this.toolCostDetail.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtFaTypeDetail, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.41688F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.58312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1008, 620);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(1002, 45);
            this.txtFaTypeDetail.TabIndex = 1;
            this.txtFaTypeDetail.Text = "费用支出单";
            this.txtFaTypeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpControl
            // 
            this.tpControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tpControl.ColumnCount = 3;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpControl.Controls.Add(this.cSupply, 2, 0);
            this.tpControl.Controls.Add(this.cSettleAcct, 0, 1);
            this.tpControl.Controls.Add(this.cSettleType, 1, 1);
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.dDate, 1, 0);
            this.tpControl.Controls.Add(this.cSettleCode, 2, 1);
            this.tpControl.Controls.Add(this.cOperator, 0, 5);
            this.tpControl.Controls.Add(this.cDepartment, 1, 5);
            this.tpControl.Controls.Add(this.cAuditor, 1, 6);
            this.tpControl.Controls.Add(this.cCreator, 0, 6);
            this.tpControl.Controls.Add(this.cRemark, 0, 3);
            this.tpControl.Controls.Add(this.dgFaType, 0, 4);
            this.tpControl.Controls.Add(this.cGUID, 2, 5);
            this.tpControl.Controls.Add(this.cTimeStamp, 2, 2);
            this.tpControl.Controls.Add(this.dAuditDate, 2, 6);
            this.tpControl.Controls.Add(this.cBank, 0, 2);
            this.tpControl.Controls.Add(this.cBankAcct, 1, 2);
            this.tpControl.Controls.Add(this.panel1, 2, 4);
            this.tpControl.Location = new System.Drawing.Point(3, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 7;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(1002, 569);
            this.tpControl.TabIndex = 5;
            // 
            // cSupply
            // 
            this.cSupply.DataTableName = "CM_Supply";
            this.cSupply.DataType = TS.Sys.Widgets.Refer.ReferType.Supply;
            this.cSupply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSupply.Label = "供应商：";
            this.cSupply.LabelWidth = 75;
            this.cSupply.Location = new System.Drawing.Point(670, 8);
            this.cSupply.Name = "cSupply";
            this.cSupply.ReferMapping = "";
            this.cSupply.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cSupply.Size = new System.Drawing.Size(329, 29);
            this.cSupply.TabIndex = 2;
            this.cSupply.Value = null;
            // 
            // cSettleAcct
            // 
            this.cSettleAcct.DataTableName = "CM_AccountDetail";
            this.cSettleAcct.DataType = TS.Sys.Widgets.Refer.ReferType.Account;
            this.cSettleAcct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleAcct.Label = "结算科目：";
            this.cSettleAcct.LabelWidth = 75;
            this.cSettleAcct.Location = new System.Drawing.Point(3, 51);
            this.cSettleAcct.Name = "cSettleAcct";
            this.cSettleAcct.ReferMapping = "";
            this.cSettleAcct.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cSettleAcct.Size = new System.Drawing.Size(327, 26);
            this.cSettleAcct.TabIndex = 3;
            this.cSettleAcct.Value = null;
            // 
            // cSettleType
            // 
            this.cSettleType.DataTableName = "CM_SettleType";
            this.cSettleType.DataType = TS.Sys.Widgets.Refer.ReferType.SettleType;
            this.cSettleType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleType.Label = "结算方式：";
            this.cSettleType.LabelWidth = 75;
            this.cSettleType.Location = new System.Drawing.Point(336, 51);
            this.cSettleType.Name = "cSettleType";
            this.cSettleType.ReferMapping = "";
            this.cSettleType.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cSettleType.Size = new System.Drawing.Size(328, 26);
            this.cSettleType.TabIndex = 4;
            this.cSettleType.Value = null;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Enabled = false;
            this.cCode.Label = "单据编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 8);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(327, 29);
            this.cCode.TabIndex = 22;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // dDate
            // 
            this.dDate.DateTimeWidth = 100;
            this.dDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dDate.Label = "单据时间：";
            this.dDate.LabelWidth = 75;
            this.dDate.Location = new System.Drawing.Point(336, 8);
            this.dDate.Name = "dDate";
            this.dDate.Require = TS.Sys.Widgets.LabelDateTime.RequireSelect.True;
            this.dDate.Size = new System.Drawing.Size(328, 29);
            this.dDate.TabIndex = 1;
            this.dDate.Value = "2011-10-17";
            // 
            // cSettleCode
            // 
            this.cSettleCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleCode.Label = "结算编号：";
            this.cSettleCode.LabelWidth = 75;
            this.cSettleCode.Location = new System.Drawing.Point(670, 51);
            this.cSettleCode.Name = "cSettleCode";
            this.cSettleCode.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.False;
            this.cSettleCode.Size = new System.Drawing.Size(329, 26);
            this.cSettleCode.TabIndex = 5;
            this.cSettleCode.TextWidth = 100;
            this.cSettleCode.Value = "";
            // 
            // cOperator
            // 
            this.cOperator.DataTableName = "CM_Employee";
            this.cOperator.DataType = TS.Sys.Widgets.Refer.ReferType.Employee;
            this.cOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cOperator.Label = "经办人：";
            this.cOperator.LabelWidth = 75;
            this.cOperator.Location = new System.Drawing.Point(3, 502);
            this.cOperator.Name = "cOperator";
            this.cOperator.ReferMapping = "";
            this.cOperator.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cOperator.Size = new System.Drawing.Size(327, 26);
            this.cOperator.TabIndex = 10;
            this.cOperator.Value = null;
            // 
            // cDepartment
            // 
            this.cDepartment.DataTableName = "CM_Department";
            this.cDepartment.DataType = TS.Sys.Widgets.Refer.ReferType.Department;
            this.cDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDepartment.Label = "部门：";
            this.cDepartment.LabelWidth = 75;
            this.cDepartment.Location = new System.Drawing.Point(336, 502);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReferMapping = "";
            this.cDepartment.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cDepartment.Size = new System.Drawing.Size(328, 26);
            this.cDepartment.TabIndex = 11;
            this.cDepartment.Value = null;
            // 
            // cAuditor
            // 
            this.cAuditor.DataTableName = "CM_User";
            this.cAuditor.DataType = TS.Sys.Widgets.Refer.ReferType.User;
            this.cAuditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cAuditor.Enabled = false;
            this.cAuditor.Label = "审核人：";
            this.cAuditor.LabelWidth = 75;
            this.cAuditor.Location = new System.Drawing.Point(336, 540);
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.ReferMapping = "";
            this.cAuditor.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cAuditor.Size = new System.Drawing.Size(328, 26);
            this.cAuditor.TabIndex = 27;
            this.cAuditor.Value = null;
            // 
            // cCreator
            // 
            this.cCreator.DataTableName = "CM_User";
            this.cCreator.DataType = TS.Sys.Widgets.Refer.ReferType.User;
            this.cCreator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCreator.Enabled = false;
            this.cCreator.Label = "制单人：";
            this.cCreator.LabelWidth = 75;
            this.cCreator.Location = new System.Drawing.Point(3, 540);
            this.cCreator.Name = "cCreator";
            this.cCreator.ReferMapping = "";
            this.cCreator.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCreator.Size = new System.Drawing.Size(327, 26);
            this.cCreator.TabIndex = 29;
            this.cCreator.Value = null;
            // 
            // cRemark
            // 
            this.tpControl.SetColumnSpan(this.cRemark, 3);
            this.cRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 75;
            this.cRemark.Location = new System.Drawing.Point(3, 128);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(996, 29);
            this.cRemark.TabIndex = 8;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // dgFaType
            // 
            this.dgFaType.AllowDrop = true;
            this.dgFaType.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFaType.ColumnHeadersHeight = 35;
            this.dgFaType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCostType,
            this.iPayAmt,
            this.cSubRemark});
            this.tpControl.SetColumnSpan(this.dgFaType, 2);
            this.dgFaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFaType.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgFaType.Location = new System.Drawing.Point(3, 163);
            this.dgFaType.Name = "dgFaType";
            this.dgFaType.RowTemplate.Height = 23;
            this.dgFaType.Size = new System.Drawing.Size(661, 329);
            this.dgFaType.TabIndex = 9;
            this.dgFaType.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFaType_CellEnter);
            this.dgFaType.Leave += new System.EventHandler(this.dgFaType_Leave);
            // 
            // cCostType
            // 
            this.cCostType.DataSource = null;
            this.cCostType.HeaderText = "支出类型";
            this.cCostType.Name = "cCostType";
            // 
            // iPayAmt
            // 
            this.iPayAmt.HeaderText = "支出金额";
            this.iPayAmt.LineBold = 0F;
            this.iPayAmt.LineSpace = 0;
            this.iPayAmt.Name = "iPayAmt";
            this.iPayAmt.NormalColor = System.Drawing.Color.Empty;
            this.iPayAmt.RedColor = System.Drawing.Color.Empty;
            this.iPayAmt.SpecialColor = System.Drawing.Color.Empty;
            // 
            // cSubRemark
            // 
            this.cSubRemark.HeaderText = "备注";
            this.cSubRemark.Name = "cSubRemark";
            this.cSubRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSubRemark.Width = 200;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(670, 498);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(182, 29);
            this.cGUID.TabIndex = 36;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 75;
            this.cTimeStamp.Location = new System.Drawing.Point(670, 83);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(228, 29);
            this.cTimeStamp.TabIndex = 37;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // dAuditDate
            // 
            this.dAuditDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dAuditDate.Enabled = false;
            this.dAuditDate.Label = "审核时间：";
            this.dAuditDate.LabelWidth = 75;
            this.dAuditDate.Location = new System.Drawing.Point(670, 537);
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.dAuditDate.Size = new System.Drawing.Size(329, 29);
            this.dAuditDate.TabIndex = 38;
            this.dAuditDate.TextWidth = 100;
            this.dAuditDate.Value = "";
            // 
            // cBank
            // 
            this.cBank.DataTableName = "CM_BankAccount";
            this.cBank.DataType = TS.Sys.Widgets.Refer.ReferType.Bank;
            this.cBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBank.Label = "付款银行：";
            this.cBank.LabelWidth = 75;
            this.cBank.Location = new System.Drawing.Point(3, 90);
            this.cBank.Name = "cBank";
            this.cBank.ReferMapping = "cBankAcct:cBankAcct;";
            this.cBank.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cBank.Size = new System.Drawing.Size(327, 27);
            this.cBank.TabIndex = 39;
            this.cBank.Value = null;
            // 
            // cBankAcct
            // 
            this.cBankAcct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBankAcct.Enabled = false;
            this.cBankAcct.Label = "银行账号：";
            this.cBankAcct.LabelWidth = 75;
            this.cBankAcct.Location = new System.Drawing.Point(336, 88);
            this.cBankAcct.Name = "cBankAcct";
            this.cBankAcct.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cBankAcct.Size = new System.Drawing.Size(328, 29);
            this.cBankAcct.TabIndex = 40;
            this.cBankAcct.TextWidth = 100;
            this.cBankAcct.Value = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TS.Forms.Properties.Resources.back;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(670, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 329);
            this.panel1.TabIndex = 41;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgAmtTypeSum, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(329, 329);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel5.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.AmtSum, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(39, 243);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(250, 53);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TS.Forms.Properties.Resources.line1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel5.SetColumnSpan(this.panel3, 2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 11);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "总计：";
            // 
            // AmtSum
            // 
            this.AmtSum.AutoSize = true;
            this.AmtSum.Font = new System.Drawing.Font("宋体", 14F);
            this.AmtSum.Location = new System.Drawing.Point(106, 17);
            this.AmtSum.Name = "AmtSum";
            this.AmtSum.Size = new System.Drawing.Size(0, 19);
            this.AmtSum.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(39, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 53);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "金额合计";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TS.Forms.Properties.Resources.line1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 10);
            this.panel2.TabIndex = 1;
            // 
            // dgAmtTypeSum
            // 
            this.dgAmtTypeSum.AllowUserToAddRows = false;
            this.dgAmtTypeSum.AllowUserToDeleteRows = false;
            this.dgAmtTypeSum.AllowUserToResizeColumns = false;
            this.dgAmtTypeSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgAmtTypeSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAmtTypeSum.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgAmtTypeSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAmtTypeSum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAmtTypeSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAmtTypeSum.ColumnHeadersVisible = false;
            this.dgAmtTypeSum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostType,
            this.TypeSum});
            this.dgAmtTypeSum.Location = new System.Drawing.Point(44, 63);
            this.dgAmtTypeSum.MultiSelect = false;
            this.dgAmtTypeSum.Name = "dgAmtTypeSum";
            this.dgAmtTypeSum.ReadOnly = true;
            this.dgAmtTypeSum.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.dgAmtTypeSum.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAmtTypeSum.RowTemplate.Height = 30;
            this.dgAmtTypeSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAmtTypeSum.Size = new System.Drawing.Size(240, 174);
            this.dgAmtTypeSum.TabIndex = 2;
            // 
            // CostType
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.CostType.DefaultCellStyle = dataGridViewCellStyle1;
            this.CostType.HeaderText = "CostType";
            this.CostType.Name = "CostType";
            this.CostType.ReadOnly = true;
            // 
            // TypeSum
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.TypeSum.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeSum.HeaderText = "amtTypeSum";
            this.TypeSum.Name = "TypeSum";
            this.TypeSum.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label3_value
            // 
            this.label3_value.AutoSize = true;
            this.label3_value.Location = new System.Drawing.Point(23, 0);
            this.label3_value.Name = "label3_value";
            this.label3_value.Size = new System.Drawing.Size(41, 12);
            this.label3_value.TabIndex = 1;
            this.label3_value.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label5_value
            // 
            this.label5_value.AutoSize = true;
            this.label5_value.Location = new System.Drawing.Point(23, 30);
            this.label5_value.Name = "label5_value";
            this.label5_value.Size = new System.Drawing.Size(41, 12);
            this.label5_value.TabIndex = 3;
            this.label5_value.Text = "label6";
            // 
            // CostDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CostDetailForm";
            this.Text = "CostDetail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFaType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmtTypeSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cSupply;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cSettleAcct;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cSettleType;
        private Sys.Widgets.LabelEdit cCode;
        private Sys.Widgets.LabelDateTime dDate;
        private Sys.Widgets.LabelEdit cSettleCode;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cOperator;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cAuditor;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cCreator;
        private Sys.Widgets.LabelEdit cRemark;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.DataGridView dgFaType;
        private Sys.Widgets.LabelEdit cGUID;
        private Sys.Widgets.LabelEdit cTimeStamp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolCostDetail;
        private Sys.Widgets.LabelEdit dAuditDate;
        private Sys.Widgets.Refer.GridRefer.DataGridViewDataControlColumn cCostType;
        private Sys.Widgets.Money.GridMoney.DataGridViewMoneyColumn iPayAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubRemark;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cBank;
        private Sys.Widgets.LabelEdit cBankAcct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2; 
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label3_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label5_value;
        private System.Windows.Forms.DataGridView dgAmtTypeSum;
        private System.Windows.Forms.Label AmtSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSum;
    }
}