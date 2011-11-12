namespace TS.Forms
{
    partial class WelcomeForm
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
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
             this.btnPu = new System.Windows.Forms.ToolStripButton();
            this.btnSa = new System.Windows.Forms.ToolStripButton();
            this.btnSt = new System.Windows.Forms.ToolStripButton();
            this.btnArAp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBase = new System.Windows.Forms.ToolStripButton(); 
            this.tpControl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpControl
            // 
            this.tpControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpControl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.toolStrip1, 0, 2);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tpControl.Location = new System.Drawing.Point(0, 0);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 3;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tpControl.Size = new System.Drawing.Size(984, 712);
            this.tpControl.TabIndex = 0;
            // 
            // toolStrip1
            // 
             this.toolStrip1.AutoSize = false;
             this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
             this.toolStrip1.BackgroundImage = global::TS.Forms.Properties.Resources.MenuBG;
             this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
             this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
             this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
             this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
             this.btnPu,
             this.btnSa,
             this.btnSt,
             this.btnArAp,
             this.toolStripSeparator1,
             this.btnBase});
             this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
             this.toolStrip1.Location = new System.Drawing.Point(0, 110);
             this.toolStrip1.Name = "toolStrip1";
             this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
             this.toolStrip1.Size = new System.Drawing.Size(180, 602);
             this.toolStrip1.TabIndex = 0;
             this.toolStrip1.Text = "toolStrip1"; 
             // 
            // btnPu
            // 
            this.btnPu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnPu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPu.Image = global::TS.Forms.Properties.Resources.Buyer;
            this.btnPu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPu.Name = "btnPu";
            this.btnPu.Size = new System.Drawing.Size(178, 50);
            this.btnPu.Text = "    采购管理";
            this.btnPu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPu.Click += new System.EventHandler(this.btnPu_Click);
            // 
            // btnSa
            // 
            this.btnSa.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnSa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSa.Image = global::TS.Forms.Properties.Resources.Sale;
            this.btnSa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSa.Name = "btnSa";
            this.btnSa.Size = new System.Drawing.Size(178, 50);
            this.btnSa.Text = "    销售管理";
            this.btnSa.Click += new System.EventHandler(this.btnSa_Click);
            // 
            // btnSt
            // 
            this.btnSt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnSt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSt.Image = global::TS.Forms.Properties.Resources.Stock;
            this.btnSt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSt.Name = "btnSt";
            this.btnSt.Size = new System.Drawing.Size(178, 50);
            this.btnSt.Text = "    库存管理";
            // 
            // btnArAp
            // 
            this.btnArAp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnArAp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArAp.Image = global::TS.Forms.Properties.Resources.ArAp;
            this.btnArAp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArAp.Name = "btnArAp";
            this.btnArAp.Size = new System.Drawing.Size(178, 50);
            this.btnArAp.Text = "    应收应付";
            this.btnArAp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArAp.Click += new System.EventHandler(this.btnArAp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // btnBase
            // 
            this.btnBase.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBase.Image = global::TS.Forms.Properties.Resources.preferences_system_2;
            this.btnBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(178, 50);
            this.btnBase.Text = "    基础数据";
            this.btnBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click); 
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.tpControl);
            this.Name = "WelcomeForm";
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tpControl.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        
        private System.Windows.Forms.ToolStripButton btnBase;
        private System.Windows.Forms.ToolStripButton btnArAp;
        private System.Windows.Forms.ToolStripButton btnPu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSt;
        private System.Windows.Forms.ToolStripButton btnSa; 

    }
}