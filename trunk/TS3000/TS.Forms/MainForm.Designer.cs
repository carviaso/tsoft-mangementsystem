namespace TS.Forms
{
    partial class MainForm
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
            this.statusBottom = new System.Windows.Forms.StatusStrip();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArrHoriz = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArrVert = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMax = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMin = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBottom
            // 
            this.statusBottom.Location = new System.Drawing.Point(0, 720);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.Size = new System.Drawing.Size(984, 22);
            this.statusBottom.TabIndex = 1;
            this.statusBottom.Text = "statusStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.收藏ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.窗口ToolStripMenuItem;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(984, 25);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 收藏ToolStripMenuItem
            // 
            this.收藏ToolStripMenuItem.Name = "收藏ToolStripMenuItem";
            this.收藏ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.收藏ToolStripMenuItem.Text = "收藏";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCascade,
            this.btnArrHoriz,
            this.btnArrVert,
            this.btnMax,
            this.btnMin});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // btnCascade
            // 
            this.btnCascade.Name = "btnCascade";
            this.btnCascade.Size = new System.Drawing.Size(152, 22);
            this.btnCascade.Text = "层叠";
            this.btnCascade.Click += new System.EventHandler(this.btnCascade_Click);
            // 
            // btnArrHoriz
            // 
            this.btnArrHoriz.Name = "btnArrHoriz";
            this.btnArrHoriz.Size = new System.Drawing.Size(152, 22);
            this.btnArrHoriz.Text = "水平平铺";
            this.btnArrHoriz.Click += new System.EventHandler(this.btnArrHoriz_Click);
            // 
            // btnArrVert
            // 
            this.btnArrVert.Name = "btnArrVert";
            this.btnArrVert.Size = new System.Drawing.Size(152, 22);
            this.btnArrVert.Text = "垂直平铺";
            this.btnArrVert.Click += new System.EventHandler(this.btnArrVert_Click);
            // 
            // btnMax
            // 
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(152, 22);
            this.btnMax.Text = "最大化";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(152, 22);
            this.btnMin.Text = "最小化";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 695);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 742);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBottom);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "天时系统3000";
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBottom;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCascade;
        private System.Windows.Forms.ToolStripMenuItem btnArrHoriz;
        private System.Windows.Forms.ToolStripMenuItem btnArrVert;
        private System.Windows.Forms.ToolStripMenuItem btnMax;
        private System.Windows.Forms.ToolStripMenuItem btnMin;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}