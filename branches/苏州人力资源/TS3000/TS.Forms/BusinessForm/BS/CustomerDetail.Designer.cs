namespace TS.Forms.BusinessForm.BS
{
    partial class CustomerDetailForm
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
            this.cName = new TS.Sys.Widgets.LabelEdit();
            this.cFullName = new TS.Sys.Widgets.LabelEdit();
            this.cShortName = new TS.Sys.Widgets.LabelEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolFaTypeDetail = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPre = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cAddress = new TS.Sys.Widgets.LabelEdit();
            this.cFax = new TS.Sys.Widgets.LabelEdit();
            this.cPhone = new TS.Sys.Widgets.LabelEdit();
            this.cContactor = new TS.Sys.Widgets.LabelEdit();
            this.cRegion = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cZip = new TS.Sys.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Widgets.LabelEdit();
            this.cBankAccount = new TS.Sys.Widgets.LabelEdit();
            this.cLegalRepre = new TS.Sys.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolFaTypeDetail.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCode.Label = "编码：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(498, 26);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 35);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(498, 26);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cFullName
            // 
            this.cFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cFullName.Label = "全名：";
            this.cFullName.LabelWidth = 75;
            this.cFullName.Location = new System.Drawing.Point(3, 67);
            this.cFullName.Name = "cFullName";
            this.cFullName.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cFullName.Size = new System.Drawing.Size(498, 26);
            this.cFullName.TabIndex = 2;
            this.cFullName.TextWidth = 100;
            this.cFullName.Value = "";
            // 
            // cShortName
            // 
            this.cShortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cShortName.Label = "简称：";
            this.cShortName.LabelWidth = 75;
            this.cShortName.Location = new System.Drawing.Point(3, 99);
            this.cShortName.Name = "cShortName";
            this.cShortName.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cShortName.Size = new System.Drawing.Size(498, 26);
            this.cShortName.TabIndex = 3;
            this.cShortName.TextWidth = 100;
            this.cShortName.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolFaTypeDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 542);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolFaTypeDetail
            // 
            this.toolFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolFaTypeDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnFirst,
            this.btnPre,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolFaTypeDetail.Location = new System.Drawing.Point(0, 0);
            this.toolFaTypeDetail.Name = "toolFaTypeDetail";
            this.toolFaTypeDetail.Size = new System.Drawing.Size(524, 45);
            this.toolFaTypeDetail.TabIndex = 0;
            this.toolFaTypeDetail.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TS.Forms.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 42);
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::TS.Forms.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 42);
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = global::TS.Forms.Properties.Resources.page_first;
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 42);
            this.btnFirst.Text = "首张";
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPre
            // 
            this.btnPre.Image = global::TS.Forms.Properties.Resources.page_prev;
            this.btnPre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(36, 42);
            this.btnPre.Text = "前张";
            this.btnPre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::TS.Forms.Properties.Resources.page_next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 42);
            this.btnNext.Text = "后张";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = global::TS.Forms.Properties.Resources.page_last;
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 42);
            this.btnLast.Text = "末张";
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TS.Forms.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 42);
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(3, 48);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(518, 491);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cFullName, 0, 2);
            this.tpControl.Controls.Add(this.cShortName, 0, 3);
            this.tpControl.Controls.Add(this.cAddress, 0, 4);
            this.tpControl.Controls.Add(this.cFax, 0, 9);
            this.tpControl.Controls.Add(this.cPhone, 0, 8);
            this.tpControl.Controls.Add(this.cContactor, 0, 7);
            this.tpControl.Controls.Add(this.cRegion, 0, 6);
            this.tpControl.Controls.Add(this.cZip, 0, 5);
            this.tpControl.Controls.Add(this.cBank, 0, 10);
            this.tpControl.Controls.Add(this.cBankAccount, 0, 11);
            this.tpControl.Controls.Add(this.cLegalRepre, 0, 12);
            this.tpControl.Controls.Add(this.cGUID, 0, 13);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 15;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(504, 459);
            this.tpControl.TabIndex = 0;
            // 
            // cAddress
            // 
            this.cAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAddress.Label = "地址：";
            this.cAddress.LabelWidth = 75;
            this.cAddress.Location = new System.Drawing.Point(3, 131);
            this.cAddress.Name = "cAddress";
            this.cAddress.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cAddress.Size = new System.Drawing.Size(498, 26);
            this.cAddress.TabIndex = 4;
            this.cAddress.TextWidth = 100;
            this.cAddress.Value = "";
            // 
            // cFax
            // 
            this.cFax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cFax.Label = "传真：";
            this.cFax.LabelWidth = 75;
            this.cFax.Location = new System.Drawing.Point(3, 291);
            this.cFax.Name = "cFax";
            this.cFax.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cFax.Size = new System.Drawing.Size(498, 26);
            this.cFax.TabIndex = 10;
            this.cFax.TextWidth = 100;
            this.cFax.Value = "";
            // 
            // cPhone
            // 
            this.cPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPhone.Label = "电话：";
            this.cPhone.LabelWidth = 75;
            this.cPhone.Location = new System.Drawing.Point(3, 259);
            this.cPhone.Name = "cPhone";
            this.cPhone.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cPhone.Size = new System.Drawing.Size(498, 26);
            this.cPhone.TabIndex = 7;
            this.cPhone.TextWidth = 100;
            this.cPhone.Value = "";
            // 
            // cContactor
            // 
            this.cContactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cContactor.Label = "联系人：";
            this.cContactor.LabelWidth = 75;
            this.cContactor.Location = new System.Drawing.Point(3, 227);
            this.cContactor.Name = "cContactor";
            this.cContactor.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cContactor.Size = new System.Drawing.Size(498, 26);
            this.cContactor.TabIndex = 6;
            this.cContactor.TextWidth = 100;
            this.cContactor.Value = "";
            // 
            // cRegion
            // 
            this.cRegion.DataType = TS.Sys.Widgets.Refer.ReferType.Region;
            this.cRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRegion.Label = "区域：";
            this.cRegion.LabelWidth = 75;
            this.cRegion.Location = new System.Drawing.Point(3, 195);
            this.cRegion.Name = "cRegion";
            this.cRegion.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cRegion.Size = new System.Drawing.Size(498, 26);
            this.cRegion.TabIndex = 5;
            this.cRegion.Value = null;
            // 
            // cZip
            // 
            this.cZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cZip.Label = "邮编：";
            this.cZip.LabelWidth = 75;
            this.cZip.Location = new System.Drawing.Point(3, 163);
            this.cZip.Name = "cZip";
            this.cZip.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cZip.Size = new System.Drawing.Size(498, 26);
            this.cZip.TabIndex = 11;
            this.cZip.TextWidth = 100;
            this.cZip.Value = "";
            // 
            // cBank
            // 
            this.cBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBank.Label = "开户银行：";
            this.cBank.LabelWidth = 75;
            this.cBank.Location = new System.Drawing.Point(3, 323);
            this.cBank.Name = "cBank";
            this.cBank.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cBank.Size = new System.Drawing.Size(498, 26);
            this.cBank.TabIndex = 12;
            this.cBank.TextWidth = 100;
            this.cBank.Value = "";
            // 
            // cBankAccount
            // 
            this.cBankAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBankAccount.Label = "银行账号：";
            this.cBankAccount.LabelWidth = 75;
            this.cBankAccount.Location = new System.Drawing.Point(3, 355);
            this.cBankAccount.Name = "cBankAccount";
            this.cBankAccount.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cBankAccount.Size = new System.Drawing.Size(498, 26);
            this.cBankAccount.TabIndex = 13;
            this.cBankAccount.TextWidth = 100;
            this.cBankAccount.Value = "";
            // 
            // cLegalRepre
            // 
            this.cLegalRepre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLegalRepre.Label = "法人代表：";
            this.cLegalRepre.LabelWidth = 75;
            this.cLegalRepre.Location = new System.Drawing.Point(3, 387);
            this.cLegalRepre.Name = "cLegalRepre";
            this.cLegalRepre.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cLegalRepre.Size = new System.Drawing.Size(498, 26);
            this.cLegalRepre.TabIndex = 14;
            this.cLegalRepre.TextWidth = 100;
            this.cLegalRepre.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 419);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cGUID.Size = new System.Drawing.Size(200, 26);
            this.cGUID.TabIndex = 15;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerDetailForm";
            this.Text = "客户";
            this.Move += new System.EventHandler(this.CustomerDetailForm_Move);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolFaTypeDetail.ResumeLayout(false);
            this.toolFaTypeDetail.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Widgets.LabelEdit cCode;
        private TS.Sys.Widgets.LabelEdit cName;
        private TS.Sys.Widgets.LabelEdit cFullName;
        private TS.Sys.Widgets.LabelEdit cShortName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolFaTypeDetail;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Widgets.LabelEdit cAddress;
        private TS.Sys.Widgets.LabelEdit cFax;
        private TS.Sys.Widgets.LabelEdit cPhone;
        private TS.Sys.Widgets.LabelEdit cContactor;
        private TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer cRegion;
        private TS.Sys.Widgets.LabelEdit cZip;
        private TS.Sys.Widgets.LabelEdit cBank;
        private TS.Sys.Widgets.LabelEdit cBankAccount;
        private TS.Sys.Widgets.LabelEdit cLegalRepre;
        private TS.Sys.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPre;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}