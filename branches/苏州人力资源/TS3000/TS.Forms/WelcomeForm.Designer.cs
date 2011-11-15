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
            this.btnMember = new System.Windows.Forms.ToolStripButton();
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
            this.btnMember,
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
            // btnMember
            // 
            this.btnMember.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMember.Image = global::TS.Forms.Properties.Resources.Employee;
            this.btnMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(178, 50);
            this.btnMember.Text = "    会员管理";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
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
        private System.Windows.Forms.ToolStripButton btnMember;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1; 

    }
}