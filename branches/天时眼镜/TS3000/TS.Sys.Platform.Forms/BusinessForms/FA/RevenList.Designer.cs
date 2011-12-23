﻿namespace TS.Sys.Platform.Forms.BusinessForm.FA
{
    partial class RevenListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolCostList = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnAudit = new System.Windows.Forms.ToolStripButton();
            this.btnUnAudit = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.gridFaReven = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolCostList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaReven)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolCostList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridFaReven, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 640);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolCostList
            // 
            this.toolCostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolCostList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnView,
            this.btnDelete,
            this.btnRefresh,
            this.btnAudit,
            this.btnUnAudit,
            this.btnExit});
            this.toolCostList.Location = new System.Drawing.Point(0, 0);
            this.toolCostList.Name = "toolCostList";
            this.toolCostList.Size = new System.Drawing.Size(1013, 45);
            this.toolCostList.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TS.Sys.Platform.Forms.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 42);
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnView
            // 
            this.btnView.Image = global::TS.Sys.Platform.Forms.Properties.Resources.See;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(36, 42);
            this.btnView.Text = "查看";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 42);
            this.btnDelete.Text = "删除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 42);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.auditor;
            this.btnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(36, 42);
            this.btnAudit.Text = "审核";
            this.btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // btnUnAudit
            // 
            this.btnUnAudit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.unauditor;
            this.btnUnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnAudit.Name = "btnUnAudit";
            this.btnUnAudit.Size = new System.Drawing.Size(48, 42);
            this.btnUnAudit.Text = "反审核";
            this.btnUnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnAudit.Click += new System.EventHandler(this.btnUnAudit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 42);
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridFaReven
            // 
            this.gridFaReven.AllowUserToAddRows = false;
            this.gridFaReven.AllowUserToDeleteRows = false;
            this.gridFaReven.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFaReven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFaReven.ColumnHeadersHeight = 35;
            this.gridFaReven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFaReven.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridFaReven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFaReven.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridFaReven.Location = new System.Drawing.Point(3, 48);
            this.gridFaReven.Name = "gridFaReven";
            this.gridFaReven.ReadOnly = true;
            this.gridFaReven.RowTemplate.Height = 23;
            this.gridFaReven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFaReven.Size = new System.Drawing.Size(1007, 589);
            this.gridFaReven.TabIndex = 5;
            this.gridFaReven.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFaReven_CellDoubleClick);
            // 
            // RevenListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RevenListForm";
            this.Text = "其他收入单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolCostList.ResumeLayout(false);
            this.toolCostList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaReven)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnAudit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolCostList;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnUnAudit;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView gridFaReven;
    }
}