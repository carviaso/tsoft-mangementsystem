namespace TS.Forms.MenuListTest
{
    partial class MenuSATest
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
            this.MenuContext = new System.Windows.Forms.TableLayoutPanel();
            this.MenuList = new System.Windows.Forms.FlowLayoutPanel();
            this.tbReport = new System.Windows.Forms.TableLayoutPanel();
            this.tbBase = new System.Windows.Forms.TableLayoutPanel();
            this.tpList = new System.Windows.Forms.TableLayoutPanel();
            this.MenuContext.SuspendLayout();
            this.MenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContext
            // 
            this.MenuContext.BackColor = System.Drawing.SystemColors.HighlightText;
           // this.MenuContext.BackgroundImage = global::TS.Forms.Properties.Resources.line;
            this.MenuContext.ColumnCount = 3;
            this.MenuContext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.MenuContext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.MenuContext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.MenuContext.Controls.Add(this.MenuList, 2, 0);
            this.MenuContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuContext.Location = new System.Drawing.Point(0, 0);
            this.MenuContext.Name = "MenuContext";
            this.MenuContext.RowCount = 1;
            this.MenuContext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuContext.Size = new System.Drawing.Size(829, 378);
            this.MenuContext.TabIndex = 2;
            // 
            // MenuList
            // 
            this.MenuList.Controls.Add(this.tbReport);
            this.MenuList.Controls.Add(this.tbBase);
            this.MenuList.Controls.Add(this.tpList);
            this.MenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuList.Location = new System.Drawing.Point(572, 3);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(254, 372);
            this.MenuList.TabIndex = 1;
            // 
            // tbReport
            // 
            this.tbReport.ColumnCount = 2;
            this.tbReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tbReport.Location = new System.Drawing.Point(3, 3);
            this.tbReport.Name = "tbReport";
            this.tbReport.RowCount = 1;
            this.tbReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tbReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tbReport.Size = new System.Drawing.Size(200, 59);
            this.tbReport.TabIndex = 4;
            // 
            // tbBase
            // 
            this.tbBase.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbBase.ColumnCount = 2;
            this.tbBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tbBase.Location = new System.Drawing.Point(3, 68);
            this.tbBase.Name = "tbBase";
            this.tbBase.RowCount = 2;
            this.tbBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbBase.Size = new System.Drawing.Size(200, 40);
            this.tbBase.TabIndex = 3;
            // 
            // tpList
            // 
            this.tpList.ColumnCount = 2;
            this.tpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tpList.Location = new System.Drawing.Point(3, 114);
            this.tpList.Name = "tpList";
            this.tpList.RowCount = 1;
            this.tpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpList.Size = new System.Drawing.Size(200, 40);
            this.tpList.TabIndex = 2;
            // 
            // MenuSATest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 378);
            this.Controls.Add(this.MenuContext);
            this.Name = "MenuSATest";
            this.Text = "MenuSA";
            this.MenuContext.ResumeLayout(false);
            this.MenuList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MenuContext;
        private System.Windows.Forms.FlowLayoutPanel MenuList;
        private System.Windows.Forms.TableLayoutPanel tbReport;
        private System.Windows.Forms.TableLayoutPanel tbBase;
        private System.Windows.Forms.TableLayoutPanel tpList;
    }
}