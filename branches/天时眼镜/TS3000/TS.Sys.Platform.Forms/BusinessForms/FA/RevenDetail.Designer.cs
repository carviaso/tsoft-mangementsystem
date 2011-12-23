namespace TS.Sys.Platform.Forms.BusinessForm.FA
{
    partial class RevenDetailForm
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
            this.cCustomer = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AmtSum = new System.Windows.Forms.Label();
            this.cSettleAcct = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.label2 = new System.Windows.Forms.Label();
            this.cSettleType = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.dDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cSettleCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cAuditor = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.dgAmtTypeSum = new System.Windows.Forms.DataGridView();
            this.cOperator = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cDepartment = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cCreator = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cRemark = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.dgFaType = new System.Windows.Forms.DataGridView();
            this.cRevenType = new TS.Sys.Platform.Widgets.Refer.GridRefer.DataGridViewDataControlColumn();
            this.iPayAmt = new TS.Sys.Platform.Widgets.Money.GridMoney.DataGridViewMoneyColumn();
            this.cSubRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.dAuditDate = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.labelEdit1 = new TS.Sys.Platform.Widgets.LabelEdit();
            this.toolCostDetail = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RevenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmtTypeSum)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaType)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCustomer
            // 
            this.cCustomer.DataTableName = "CM_Customer";
            this.cCustomer.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Customer;
            this.cCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCustomer.Label = "客户：";
            this.cCustomer.LabelWidth = 75;
            this.cCustomer.Location = new System.Drawing.Point(571, 8);
            this.cCustomer.Name = "cCustomer";
            this.cCustomer.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cCustomer.Size = new System.Drawing.Size(279, 29);
            this.cCustomer.TabIndex = 2;
            this.cCustomer.Value = null;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(14, 4);
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
            this.panel2.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.line1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 10);
            this.panel2.TabIndex = 1;
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
            // cSettleAcct
            // 
            this.cSettleAcct.DataTableName = "CM_AccountDetail";
            this.cSettleAcct.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Account;
            this.cSettleAcct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleAcct.Label = "结算科目：";
            this.cSettleAcct.LabelWidth = 75;
            this.cSettleAcct.Location = new System.Drawing.Point(3, 51);
            this.cSettleAcct.Name = "cSettleAcct";
            this.cSettleAcct.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cSettleAcct.Size = new System.Drawing.Size(278, 26);
            this.cSettleAcct.TabIndex = 3;
            this.cSettleAcct.Value = null;
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
            // cSettleType
            // 
            this.cSettleType.DataTableName = "CM_SettleType";
            this.cSettleType.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.SettleType;
            this.cSettleType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleType.Label = "结算方式：";
            this.cSettleType.LabelWidth = 75;
            this.cSettleType.Location = new System.Drawing.Point(287, 51);
            this.cSettleType.Name = "cSettleType";
            this.cSettleType.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cSettleType.Size = new System.Drawing.Size(278, 26);
            this.cSettleType.TabIndex = 4;
            this.cSettleType.Value = null;
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(14, 186);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(250, 53);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.line1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel5.SetColumnSpan(this.panel3, 2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 11);
            this.panel3.TabIndex = 2;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Enabled = false;
            this.cCode.Label = "单据编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 8);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(278, 29);
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
            this.dDate.Location = new System.Drawing.Point(287, 8);
            this.dDate.Name = "dDate";
            this.dDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.True;
            this.dDate.Size = new System.Drawing.Size(278, 29);
            this.dDate.TabIndex = 1;
            this.dDate.Value = "2011-10-17";
            // 
            // cSettleCode
            // 
            this.cSettleCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleCode.Label = "结算编号：";
            this.cSettleCode.LabelWidth = 75;
            this.cSettleCode.Location = new System.Drawing.Point(571, 51);
            this.cSettleCode.Name = "cSettleCode";
            this.cSettleCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cSettleCode.Size = new System.Drawing.Size(279, 26);
            this.cSettleCode.TabIndex = 5;
            this.cSettleCode.TextWidth = 100;
            this.cSettleCode.Value = "";
            // 
            // cAuditor
            // 
            this.cAuditor.DataTableName = "Sys_User";
            this.cAuditor.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cAuditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cAuditor.Enabled = false;
            this.cAuditor.Label = "审核人：";
            this.cAuditor.LabelWidth = 75;
            this.cAuditor.Location = new System.Drawing.Point(287, 483);
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cAuditor.Size = new System.Drawing.Size(278, 26);
            this.cAuditor.TabIndex = 27;
            this.cAuditor.Value = null;
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
            this.RevenType,
            this.TypeSum});
            this.dgAmtTypeSum.Location = new System.Drawing.Point(19, 63);
            this.dgAmtTypeSum.MultiSelect = false;
            this.dgAmtTypeSum.Name = "dgAmtTypeSum";
            this.dgAmtTypeSum.ReadOnly = true;
            this.dgAmtTypeSum.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.dgAmtTypeSum.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAmtTypeSum.RowTemplate.Height = 30;
            this.dgAmtTypeSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAmtTypeSum.Size = new System.Drawing.Size(240, 117);
            this.dgAmtTypeSum.TabIndex = 2;
            // 
            // cOperator
            // 
            this.cOperator.DataTableName = "CM_Employee";
            this.cOperator.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Employee;
            this.cOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cOperator.Label = "经办人：";
            this.cOperator.LabelWidth = 75;
            this.cOperator.Location = new System.Drawing.Point(3, 445);
            this.cOperator.Name = "cOperator";
            this.cOperator.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cOperator.Size = new System.Drawing.Size(278, 26);
            this.cOperator.TabIndex = 10;
            this.cOperator.Value = null;
            // 
            // cDepartment
            // 
            this.cDepartment.DataTableName = "CM_Department";
            this.cDepartment.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Department;
            this.cDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDepartment.Label = "部门：";
            this.cDepartment.LabelWidth = 75;
            this.cDepartment.Location = new System.Drawing.Point(287, 445);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cDepartment.Size = new System.Drawing.Size(278, 26);
            this.cDepartment.TabIndex = 11;
            this.cDepartment.Value = null;
            // 
            // cCreator
            // 
            this.cCreator.DataTableName = "Sys_User";
            this.cCreator.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cCreator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCreator.Enabled = false;
            this.cCreator.Label = "制单人：";
            this.cCreator.LabelWidth = 75;
            this.cCreator.Location = new System.Drawing.Point(3, 483);
            this.cCreator.Name = "cCreator";
            this.cCreator.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCreator.Size = new System.Drawing.Size(278, 26);
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
            this.cRemark.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(847, 29);
            this.cRemark.TabIndex = 8;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 272);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.back;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(571, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 272);
            this.panel1.TabIndex = 41;
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(853, 41);
            this.txtFaTypeDetail.TabIndex = 1;
            this.txtFaTypeDetail.Text = "其他收入单";
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
            this.tpControl.Controls.Add(this.cCustomer, 2, 0);
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
            this.tpControl.Controls.Add(this.labelEdit1, 1, 2);
            this.tpControl.Controls.Add(this.panel1, 2, 4);
            this.tpControl.Location = new System.Drawing.Point(3, 44);
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
            this.tpControl.Size = new System.Drawing.Size(853, 512);
            this.tpControl.TabIndex = 5;
            // 
            // dgFaType
            // 
            this.dgFaType.AllowDrop = true;
            this.dgFaType.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFaType.ColumnHeadersHeight = 35;
            this.dgFaType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRevenType,
            this.iPayAmt,
            this.cSubRemark});
            this.tpControl.SetColumnSpan(this.dgFaType, 2);
            this.dgFaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFaType.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgFaType.Location = new System.Drawing.Point(3, 163);
            this.dgFaType.Name = "dgFaType";
            this.dgFaType.RowTemplate.Height = 23;
            this.dgFaType.Size = new System.Drawing.Size(562, 272);
            this.dgFaType.TabIndex = 9;
            this.dgFaType.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFaType_CellEnter);
            this.dgFaType.Leave += new System.EventHandler(this.dgFaType_Leave);
            // 
            // cRevenType
            // 
            this.cRevenType.DataSource = null;
            this.cRevenType.HeaderText = "收入类型";
            this.cRevenType.Name = "cRevenType";
            // 
            // iPayAmt
            // 
            this.iPayAmt.HeaderText = "收入金额";
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
            this.cGUID.Location = new System.Drawing.Point(571, 441);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
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
            this.cTimeStamp.Location = new System.Drawing.Point(571, 83);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
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
            this.dAuditDate.Location = new System.Drawing.Point(571, 480);
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.dAuditDate.Size = new System.Drawing.Size(279, 29);
            this.dAuditDate.TabIndex = 38;
            this.dAuditDate.TextWidth = 100;
            this.dAuditDate.Value = "";
            // 
            // cBank
            // 
            this.cBank.DataTableName = "CM_Bank";
            this.cBank.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Bank;
            this.cBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBank.Label = "付款银行：";
            this.cBank.LabelWidth = 75;
            this.cBank.Location = new System.Drawing.Point(3, 90);
            this.cBank.Name = "cBank";
            this.cBank.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cBank.Size = new System.Drawing.Size(278, 27);
            this.cBank.TabIndex = 39;
            this.cBank.Value = null;
            // 
            // labelEdit1
            // 
            this.labelEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelEdit1.Enabled = false;
            this.labelEdit1.Label = "银行账号：";
            this.labelEdit1.LabelWidth = 75;
            this.labelEdit1.Location = new System.Drawing.Point(287, 88);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.labelEdit1.Size = new System.Drawing.Size(278, 29);
            this.labelEdit1.TabIndex = 40;
            this.labelEdit1.TextWidth = 100;
            this.labelEdit1.Value = "";
            // 
            // toolCostDetail
            // 
            this.toolCostDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolCostDetail.Location = new System.Drawing.Point(1, 1);
            this.toolCostDetail.Name = "toolCostDetail";
            this.toolCostDetail.Size = new System.Drawing.Size(865, 45);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 559);
            this.tableLayoutPanel2.TabIndex = 4;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 613);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // RevenType
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.RevenType.DefaultCellStyle = dataGridViewCellStyle1;
            this.RevenType.HeaderText = "CostType";
            this.RevenType.Name = "RevenType";
            this.RevenType.ReadOnly = true;
            // 
            // TypeSum
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.TypeSum.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeSum.HeaderText = "amtTypeSum";
            this.TypeSum.Name = "TypeSum";
            this.TypeSum.ReadOnly = true;
            // 
            // RevenDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RevenDetailForm";
            this.Text = "RevenDetail";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmtTypeSum)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFaType)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AmtSum;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cSettleAcct;
        private System.Windows.Forms.Label label2;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cSettleType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.LabelDateTime dDate;
        private TS.Sys.Platform.Widgets.LabelEdit cSettleCode;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cAuditor;
        private System.Windows.Forms.DataGridView dgAmtTypeSum;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cOperator;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cCreator;
        private TS.Sys.Platform.Widgets.LabelEdit cRemark;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.DataGridView dgFaType;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private TS.Sys.Platform.Widgets.LabelEdit cTimeStamp;
        private TS.Sys.Platform.Widgets.LabelEdit dAuditDate;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cBank;
        private TS.Sys.Platform.Widgets.LabelEdit labelEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private System.Windows.Forms.ToolStrip toolCostDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TS.Sys.Platform.Widgets.Refer.GridRefer.DataGridViewDataControlColumn cRevenType;
        private TS.Sys.Platform.Widgets.Money.GridMoney.DataGridViewMoneyColumn iPayAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSum;

    }
}