namespace TS.Forms.BusinessForm.BS
{
    partial class RegionDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolFaTypeDetail = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.cCode = new TS.Sys.Widgets.LabelEdit();
            this.cName = new TS.Sys.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Widgets.LabelEdit();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPre = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolFaTypeDetail.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolFaTypeDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 224);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.toolFaTypeDetail.Size = new System.Drawing.Size(299, 45);
            this.toolFaTypeDetail.TabIndex = 0;
            this.toolFaTypeDetail.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
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
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 42);
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // 
            // tpControl
            // 
            this.tpControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.txtFaTypeDetail, 0, 0);
            this.tpControl.Controls.Add(this.cCode, 0, 1);
            this.tpControl.Controls.Add(this.cName, 0, 2);
            this.tpControl.Controls.Add(this.cGUID, 0, 3);
            this.tpControl.Location = new System.Drawing.Point(34, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 4;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(230, 163);
            this.tpControl.TabIndex = 1;
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(224, 40);
            this.txtFaTypeDetail.TabIndex = 0;
            this.txtFaTypeDetail.Text = "区域属性";
            this.txtFaTypeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cCode.Label = "代码：";
            this.cCode.LabelWidth = 48;
            this.cCode.Location = new System.Drawing.Point(3, 43);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(224, 29);
            this.cCode.TabIndex = 1;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 48;
            this.cName.Location = new System.Drawing.Point(3, 83);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(224, 29);
            this.cName.TabIndex = 2;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID:";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 123);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Widgets.LabelEdit.RequireSelect.True;
            this.cGUID.Size = new System.Drawing.Size(200, 29);
            this.cGUID.TabIndex = 4;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
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
            // RegionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 224);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegionDetailForm";
            this.Text = "区域属性";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolFaTypeDetail.ResumeLayout(false);
            this.toolFaTypeDetail.PerformLayout();
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolFaTypeDetail;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private TS.Sys.Widgets.LabelEdit cCode;
        private TS.Sys.Widgets.LabelEdit cName;
        private TS.Sys.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPre;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}