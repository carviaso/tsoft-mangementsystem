using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Domain; 

namespace TS.Forms.MenuList
{
    public class MenuContext:TableLayoutPanel
    {
        private MainForm _mainForm; 
        private Hashtable _menuMap;
        private MenuService ms;
        private FlowLayoutPanel MenuList;
        private TableLayoutPanel tpBase;
        private TableLayoutPanel tpList;
        private TableLayoutPanel tpReport;
        private Panel panel1;
      
        public MenuContext(MainForm mainForm)
        {
            this._mainForm = mainForm;
            ms = new MenuService();
            _menuMap = new Hashtable(); 
            initComponent();            
        }

        public MenuContext(MainForm mainForm, String modual)
            : this(mainForm)
        { 
            GetMenuBase(modual);
            GetMenuList(modual);
            GetMenuReport(modual);
        }
        private void GetMenuBase(String modual)
        {
            ArrayList mList = GetMenuContextList(modual, "base");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpBase.Controls.Add(InitMenuContext(mi), 1, i + 1);
                this.tpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                this.tpBase.Height += 20;
                this.tpList.Location = new Point(this.tpList.Location.X,this.tpList.Location.Y+20);
                this.tpReport.Location = new Point(this.tpReport.Location.X, this.tpReport.Location.Y + 20);
            }
        }
        private void GetMenuList(String modual)
        {
            ArrayList mList = GetMenuContextList(modual, "list");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpList.Controls.Add(InitMenuContext(mi), 1, i + 1);
                this.tpList.RowStyles.Add(new RowStyle( SizeType.Absolute, 20F));
                this.tpList.Height += 20;
                this.tpReport.Location = new Point(this.tpReport.Location.X, this.tpReport.Location.Y + 20);
            }
        }

        private void GetMenuReport(String modual)
        {
            ArrayList mList = GetMenuContextList(modual, "report");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpReport.Controls.Add(InitMenuContext(mi), 1, i + 1);
                this.tpReport.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                this.tpReport.Height += 20;
            }
        }

        

        private ArrayList GetMenuContextList(String modual, String cField)
        {
            Hashtable con = new Hashtable();
            con.Add("cParent", modual);
            con.Add("cField", cField);
            return ms.GetResultList(con);
        }

        /// <summary>
        /// 初始化菜单
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <returns></returns>
        private LinkLabel InitMenuContext(MenuInfo menuInfo)
        {
            LinkLabel linkLabel = new LinkLabel();
            _menuMap.Add(menuInfo.cCode, menuInfo.cForm);
            linkLabel.Anchor = AnchorStyles.Left;
            linkLabel.AutoSize = true;
            linkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel.LinkColor = Color.Black;
            linkLabel.Location = new Point(53, 34);
            linkLabel.Name = menuInfo.cCode.ToString();
            linkLabel.Size = new Size(65, 12);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = menuInfo.cTitle.ToString();
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.menuClicked);
            return linkLabel;
        }

        /// <summary>
        /// 链接点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                LinkLabel link = (LinkLabel)sender;
                String test = link.Name;
                String formUrl = _menuMap[link.Name].ToString();
                Type t = tempAssembly.GetType(formUrl);
                object o = System.Activator.CreateInstance(t, null);

                int index = 0;
                foreach (Form f in this._mainForm.MdiChildren)
                {
                    if (f.Name.Equals(((Form)o).Name))
                    {
                        f.Activate();
                        break;
                    }
                    index++;
                }
                if (index == this._mainForm.MdiChildren.Length)
                {
                    ((Form)o).MdiParent = this._mainForm;
                    ((Form)o).Show();
                    this._mainForm.AddChildItem(((Form)o).Name, ((Form)o).Text);
                }
            }
            catch (Exception ex)
            {
                Msg.Show(ExceptionConst.Error_Form);
            }
            
        }

        private void initComponent()
        {

            this.MenuList = new FlowLayoutPanel();
            this.tpList = new TableLayoutPanel();
            this.tpBase = new TableLayoutPanel();
            this.tpReport = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.MenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContext
            // 
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ColumnCount = 3;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            this.Controls.Add(this.panel1, 1, 0);
            this.Controls.Add(this.MenuList, 2, 0);
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            this.Name = "MenuContext";
            this.RowCount = 1;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Size = new Size(720, 650);
            this.TabIndex = 2;
            //测试用，将表格线显示出来
            //this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TS.Forms.Properties.Resources.line;
            this.panel1.Location = new Point(490, 3);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(11, 650);
            this.panel1.TabIndex = 2;
            //this.panel1.BorderStyle = BorderStyle.FixedSingle;

            // 
            // MenuList
            // 
            this.MenuList.Controls.Add(this.tpBase);
            this.MenuList.Controls.Add(this.tpList);
            this.MenuList.Controls.Add(this.tpReport);
            this.MenuList.Dock = DockStyle.Fill;
            this.MenuList.Location = new Point(503, 3);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(208, 650);
            this.MenuList.TabIndex = 0; 
            // 
            // tpBase
            //  
            this.tpBase.ColumnCount = 2;
            this.tpBase.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 30F));
            this.tpBase.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 150F));
            this.tpBase.Location = new Point(3, 3);
            this.tpBase.Name = "tpBase";
            this.tpBase.RowCount = 1;
            this.tpBase.RowStyles.Add(new RowStyle( SizeType.Absolute, 30F));
            this.tpBase.Size = new Size(200, 40);
            this.tpBase.TabIndex = 3;
            //测试用，将表格线显示出来
            //this.tpBase.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // 
            // tpList
            // 
            this.tpList.ColumnCount = 2;
            this.tpList.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 30F));
            this.tpList.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 150F));
            this.tpList.Location = new System.Drawing.Point(3, 39);
            this.tpList.Name = "tpList";
            this.tpList.RowCount = 1;
            this.tpList.RowStyles.Add(new RowStyle( SizeType.Absolute, 30F));
            this.tpList.Size = new System.Drawing.Size(200, 40);
            this.tpList.TabIndex = 2;
            //测试用，将表格线显示出来
            //this.tpList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // 
            // tpReport
            // 
            this.tpReport.ColumnCount = 2;
            this.tpReport.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 30F));
            this.tpReport.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 150F));
            this.tpReport.Location = new Point(3, 85);
            this.tpReport.Name = "tpReport";
            this.tpReport.RowCount = 1;
            this.tpReport.RowStyles.Add(new RowStyle( SizeType.Absolute, 30F));
            this.tpReport.Size = new Size(200, 40);
            this.tpReport.TabIndex = 4;
            //测试用，将表格线显示出来
            //this.tpReport.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }
    }
}
