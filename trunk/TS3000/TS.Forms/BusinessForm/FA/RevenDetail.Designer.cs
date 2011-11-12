namespace TS.Forms.BusinessForm.FA
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
            this.cCode = new TS.Sys.Widgets.LabelEdit();
            this.dDate = new TS.Sys.Widgets.LabelDateTime();
            this.cSettleCode = new TS.Sys.Widgets.LabelEdit();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.cAuditor = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolCostDetail = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cCustomer = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cSettleAcct = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cSettleType = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cOperator = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cDepartment = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cCreator = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cRemark = new TS.Sys.Widgets.LabelEdit();
            this.dgFaType = new System.Windows.Forms.DataGridView();
            this.cRevenType = new TS.Sys.Widgets.Refer.GridRefer.DataGridViewDataControlColumn();
            this.iPayAMT = new TS.Sys.Widgets.Amt.GridAmt.DataGridViewAmtColumn();
            this.cSubRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAuditDate = new TS.Sys.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Widgets.LabelCombox();
            this.cBankAcct = new TS.Sys.Widgets.LabelCombox();
            this.cGUID = new TS.Sys.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaType)).BeginInit();
            this.SuspendLayout();
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
            this.cCode.Size = new System.Drawing.Size(333, 29);
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
            this.dDate.Location = new System.Drawing.Point(342, 8);
            this.dDate.Name = "dDate";
            this.dDate.Require = TS.Sys.Widgets.LabelDateTime.RequireSelect.True;
            this.dDate.Size = new System.Drawing.Size(333, 29);
            this.dDate.TabIndex = 1;
            this.dDate.Value = "2011-10-17";
            // 
            // cSettleCode
            // 
            this.cSettleCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleCode.Label = "结算编号：";
            this.cSettleCode.LabelWidth = 75;
            this.cSettleCode.Location = new System.Drawing.Point(681, 51);
            this.cSettleCode.Name = "cSettleCode";
            this.cSettleCode.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cSettleCode.Size = new System.Drawing.Size(334, 26);
            this.cSettleCode.TabIndex = 5;
            this.cSettleCode.TextWidth = 100;
            this.cSettleCode.Value = "";
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(1018, 41);
            this.txtFaTypeDetail.TabIndex = 1;
            this.txtFaTypeDetail.Text = "其他收入单";
            this.txtFaTypeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cAuditor
            // 
            this.cAuditor.DataType = TS.Sys.Widgets.Refer.ReferType.User;
            this.cAuditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cAuditor.Enabled = false;
            this.cAuditor.Label = "审核人：";
            this.cAuditor.LabelWidth = 75;
            this.cAuditor.Location = new System.Drawing.Point(342, 481);
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cAuditor.Size = new System.Drawing.Size(333, 26);
            this.cAuditor.TabIndex = 27;
            this.cAuditor.DataTableName = "CM_User";
            this.cAuditor.Value = null;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 611);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolCostDetail
            // 
            this.toolCostDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolCostDetail.Location = new System.Drawing.Point(1, 1);
            this.toolCostDetail.Name = "toolCostDetail";
            this.toolCostDetail.Size = new System.Drawing.Size(1030, 45);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1024, 557);
            this.tableLayoutPanel2.TabIndex = 4;
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
            this.tpControl.Controls.Add(this.dAuditDate, 2, 6);
            this.tpControl.Controls.Add(this.cBank, 0, 2);
            this.tpControl.Controls.Add(this.cBankAcct, 1, 2);
            this.tpControl.Controls.Add(this.cGUID, 2, 5);
            this.tpControl.Controls.Add(this.cTimeStamp, 2, 2);
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
            this.tpControl.Size = new System.Drawing.Size(1018, 510);
            this.tpControl.TabIndex = 5;
            // 
            // cCustomer
            // 
            this.cCustomer.DataType = TS.Sys.Widgets.Refer.ReferType.Customer;
            this.cCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCustomer.Label = "供应商：";
            this.cCustomer.LabelWidth = 75;
            this.cCustomer.Location = new System.Drawing.Point(681, 8);
            this.cCustomer.Name = "cCustomer";
            this.cCustomer.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCustomer.Size = new System.Drawing.Size(334, 29);
            this.cCustomer.TabIndex = 2;
            this.cCustomer.DataTableName = "CM_Customer";
            this.cCustomer.Value = null;
            // 
            // cSettleAcct
            // 
            this.cSettleAcct.DataType = TS.Sys.Widgets.Refer.ReferType.Account;
            this.cSettleAcct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleAcct.Label = "结算科目：";
            this.cSettleAcct.LabelWidth = 75;
            this.cSettleAcct.Location = new System.Drawing.Point(3, 51);
            this.cSettleAcct.Name = "cSettleAcct";
            this.cSettleAcct.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cSettleAcct.Size = new System.Drawing.Size(333, 26);
            this.cSettleAcct.TabIndex = 3;
            this.cSettleAcct.DataTableName = "CM_Account";
            this.cSettleAcct.Value = null;
            // 
            // cSettleType
            // 
            this.cSettleType.DataType = TS.Sys.Widgets.Refer.ReferType.SettleType;
            this.cSettleType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cSettleType.Label = "结算方式：";
            this.cSettleType.LabelWidth = 75;
            this.cSettleType.Location = new System.Drawing.Point(342, 51);
            this.cSettleType.Name = "cSettleType";
            this.cSettleType.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cSettleType.Size = new System.Drawing.Size(333, 26);
            this.cSettleType.TabIndex = 4;
            this.cSettleType.DataTableName = "CM_SettleType";
            this.cSettleType.Value = null;
            // 
            // cOperator
            // 
            this.cOperator.DataType = TS.Sys.Widgets.Refer.ReferType.Employee;
            this.cOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cOperator.Label = "经办人：";
            this.cOperator.LabelWidth = 75;
            this.cOperator.Location = new System.Drawing.Point(3, 443);
            this.cOperator.Name = "cOperator";
            this.cOperator.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cOperator.Size = new System.Drawing.Size(333, 26);
            this.cOperator.TabIndex = 10;
            this.cOperator.DataTableName = "CM_Employee";
            this.cOperator.Value = null;
            // 
            // cDepartment
            // 
            this.cDepartment.DataType = TS.Sys.Widgets.Refer.ReferType.Department;
            this.cDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDepartment.Label = "部门：";
            this.cDepartment.LabelWidth = 75;
            this.cDepartment.Location = new System.Drawing.Point(342, 443);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cDepartment.Size = new System.Drawing.Size(333, 26);
            this.cDepartment.TabIndex = 11;
            this.cDepartment.DataTableName = "CM_Department";
            this.cDepartment.Value = null;
            // 
            // cCreator
            // 
            this.cCreator.DataType = TS.Sys.Widgets.Refer.ReferType.User;
            this.cCreator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCreator.Enabled = false;
            this.cCreator.Label = "制单人：";
            this.cCreator.LabelWidth = 75;
            this.cCreator.Location = new System.Drawing.Point(3, 481);
            this.cCreator.Name = "cCreator";
            this.cCreator.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCreator.Size = new System.Drawing.Size(333, 26);
            this.cCreator.TabIndex = 29;
            this.cCreator.DataTableName = "CM_User";
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
            this.cRemark.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cRemark.Size = new System.Drawing.Size(1012, 29);
            this.cRemark.TabIndex = 8;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // dgFaType
            // 
            this.dgFaType.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFaType.ColumnHeadersHeight = 35;
            this.dgFaType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgFaType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRevenType,
            this.iPayAMT,
            this.cSubRemark});
            this.tpControl.SetColumnSpan(this.dgFaType, 3);
            this.dgFaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFaType.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgFaType.Location = new System.Drawing.Point(3, 163);
            this.dgFaType.Name = "dgFaType";
            this.dgFaType.RowTemplate.Height = 23;
            this.dgFaType.Size = new System.Drawing.Size(1012, 270);
            this.dgFaType.TabIndex = 9;
            // 
            // cRevenType
            // 
            this.cRevenType.DataSource = null;
            //this.cRevenType.DataType = TS.Sys.Widgets.Refer.ReferType.none;
            this.cRevenType.HeaderText = "收入类型";
            this.cRevenType.Name = "cRevenType"; 
            // 
            // iPayAMT
            // 
            this.iPayAMT.HeaderText = "收款金额";
            this.iPayAMT.iPrecision = null;
            this.iPayAMT.Name = "iPayAMT";
            // 
            // cSubRemark
            // 
            this.cSubRemark.HeaderText = "备注";
            this.cSubRemark.Name = "cSubRemark";
            this.cSubRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSubRemark.Width = 200;
            // 
            // dAuditDate
            // 
            this.dAuditDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dAuditDate.Enabled = false;
            this.dAuditDate.Label = "审核时间：";
            this.dAuditDate.LabelWidth = 75;
            this.dAuditDate.Location = new System.Drawing.Point(681, 481);
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.False;
            this.dAuditDate.Size = new System.Drawing.Size(334, 26);
            this.dAuditDate.TabIndex = 33;
            this.dAuditDate.TextWidth = 100;
            this.dAuditDate.Value = "";
            // 
            // cBank
            // 
            this.cBank.CbxFont = null;
            this.cBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBank.Editable = false;
            this.cBank.ItemValues = null;
            this.cBank.Label = "收款银行：";
            this.cBank.LabelWidth = 75;
            this.cBank.Location = new System.Drawing.Point(3, 91);
            this.cBank.Name = "cBank";
            this.cBank.Require = TS.Sys.Widgets.LabelCombox.RequireSelect.True;
            this.cBank.Size = new System.Drawing.Size(333, 26);
            this.cBank.Sql = null;
            this.cBank.TabIndex = 6;
            this.cBank.Value = null;
            // 
            // cBankAcct
            // 
            this.cBankAcct.CbxFont = null;
            this.cBankAcct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBankAcct.Editable = false;
            this.cBankAcct.ItemValues = null;
            this.cBankAcct.Label = "银行账号：";
            this.cBankAcct.LabelWidth = 75;
            this.cBankAcct.Location = new System.Drawing.Point(342, 91);
            this.cBankAcct.Name = "cBankAcct";
            this.cBankAcct.Require = TS.Sys.Widgets.LabelCombox.RequireSelect.True;
            this.cBankAcct.Size = new System.Drawing.Size(333, 26);
            this.cBankAcct.Sql = null;
            this.cBankAcct.TabIndex = 7;
            this.cBankAcct.Value = null;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(681, 439);
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
            this.cTimeStamp.Location = new System.Drawing.Point(681, 83);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(228, 29);
            this.cTimeStamp.TabIndex = 37;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // RevenDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RevenDetailForm";
            this.Text = "RevenDetail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFaType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cSettleAcct;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cSettleType;
        private Sys.Widgets.LabelEdit cCode;
        private Sys.Widgets.LabelDateTime dDate;
        private Sys.Widgets.LabelEdit cSettleCode;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cOperator;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cAuditor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolCostDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cCustomer;
        private Sys.Widgets.Refer.WidgetRefer.LabelRefer cCreator;
        private Sys.Widgets.LabelEdit cRemark;
        private System.Windows.Forms.DataGridView dgFaType;
        private Sys.Widgets.LabelEdit dAuditDate;
        private Sys.Widgets.LabelCombox cBank;
        private Sys.Widgets.LabelCombox cBankAcct;
        private Sys.Widgets.LabelEdit cGUID;
        private Sys.Widgets.LabelEdit cTimeStamp;
        private Sys.Widgets.Refer.GridRefer.DataGridViewDataControlColumn cRevenType;
        private Sys.Widgets.Amt.GridAmt.DataGridViewAmtColumn iPayAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubRemark;
    }
}