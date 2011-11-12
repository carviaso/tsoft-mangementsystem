namespace TS.Forms.BusinessForm.BS
{
    partial class DepartmentDetailForm
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
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.cCode = new TS.Sys.Widgets.LabelEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolFaTypeDetail = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cName = new TS.Sys.Widgets.LabelEdit();
            this.cFullName = new TS.Sys.Widgets.LabelEdit();
            this.cParent = new TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cGUID = new TS.Sys.Widgets.LabelEdit();
            this.cRemark = new TS.Sys.Widgets.LabelEdit();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPre = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolFaTypeDetail.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            //  
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 42);
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCode.Label = "编码：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(354, 26);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 296);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.toolFaTypeDetail.Size = new System.Drawing.Size(380, 45);
            this.toolFaTypeDetail.TabIndex = 0;
            this.toolFaTypeDetail.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TS.Forms.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 42);
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TS.Forms.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
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
            this.tbControl.Size = new System.Drawing.Size(374, 245);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 219);
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
            this.tpControl.Controls.Add(this.cParent, 0, 3);
            this.tpControl.Controls.Add(this.cGUID, 0, 5);
            this.tpControl.Controls.Add(this.cRemark, 0, 4);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 7;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.Size = new System.Drawing.Size(360, 213);
            this.tpControl.TabIndex = 0;
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 35);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(354, 26);
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
            this.cFullName.Size = new System.Drawing.Size(354, 26);
            this.cFullName.TabIndex = 2;
            this.cFullName.TextWidth = 100;
            this.cFullName.Value = "";
            // 
            // cParent
            // 
            this.cParent.DataType = TS.Sys.Widgets.Refer.ReferType.Department;
            this.cParent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cParent.Label = "所属部门：";
            this.cParent.LabelWidth = 75;
            this.cParent.Location = new System.Drawing.Point(3, 99);
            this.cParent.Name = "cParent";
            this.cParent.Require = TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cParent.Size = new System.Drawing.Size(354, 26);
            this.cParent.TabIndex = 16;
            this.cParent.Value = null;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 163);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cGUID.Size = new System.Drawing.Size(200, 26);
            this.cGUID.TabIndex = 17;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cRemark
            // 
            this.cRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 75;
            this.cRemark.Location = new System.Drawing.Point(3, 131);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cRemark.Size = new System.Drawing.Size(354, 26);
            this.cRemark.TabIndex = 18;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
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
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 42);
            this.btnFirst.Text = "首张";
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnPre
            // 
            this.btnPre.Image = global::TS.Forms.Properties.Resources.page_prev;
            this.btnPre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(36, 42);
            this.btnPre.Text = "前张";
            this.btnPre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::TS.Forms.Properties.Resources.page_next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 42);
            this.btnNext.Text = "后张";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLast
            // 
            this.btnLast.Image = global::TS.Forms.Properties.Resources.page_last;
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 42);
            this.btnLast.Text = "末张";
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // DepartmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 296);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepartmentDetailForm";
            this.Text = "部门属性";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentDetail_FormClosing);
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

        private System.Windows.Forms.ToolStripButton btnSave;
        private TS.Sys.Widgets.LabelEdit cCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolFaTypeDetail;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Widgets.LabelEdit cName;
        private TS.Sys.Widgets.LabelEdit cFullName;
        private TS.Sys.Widgets.Refer.WidgetRefer.LabelRefer cParent;
        private TS.Sys.Widgets.LabelEdit cGUID;
        private TS.Sys.Widgets.LabelEdit cRemark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPre;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}