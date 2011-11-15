using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;

namespace TS.Forms.MenuListTest
{
    public partial class MenuSATest : Form
    {
        private MenuService ms;
        private Hashtable menuMap;

        public MenuSATest()
        {
            InitializeComponent();
            ms = new MenuService();
            menuMap = new Hashtable();
            GetMenuBase();
                
        }

        private void GetMenuList()
        {
            ArrayList mList = GetMenuContextList("sa", "list");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpList.Controls.Add(InitMenuContext(mi), 1, i + 1);
            }
        }

        private void GetMenuReport()
        {
            ArrayList mList = GetMenuContextList("sa", "report");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpList.Controls.Add(InitMenuContext(mi), 1, i + 1);
            }
        }

        private void GetMenuBase()
        {
            ArrayList mList = GetMenuContextList("sa", "base");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi,mDetail);
                this.tpList.Controls.Add(InitMenuContext(mi), 1, i + 1);
            }
        }

        private ArrayList GetMenuContextList(String modual,String cField)
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
            menuMap.Add(menuInfo.cCode, menuInfo.cForm);
            linkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            linkLabel.AutoSize = true;
            linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            linkLabel.LinkColor = System.Drawing.Color.Black;
            linkLabel.Location = new System.Drawing.Point(53, 34);
            linkLabel.Name = menuInfo.cCode.ToString();
            linkLabel.Size = new System.Drawing.Size(65, 12);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = menuInfo.cTitle.ToString();
            linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menuClicked);
            return linkLabel;
        }

        /// <summary>
        /// 链接点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();
            LinkLabel link = (LinkLabel)sender;
            String test = link.Name;
            String formUrl = menuMap[link.Name].ToString();
            Type t = tempAssembly.GetType(formUrl);
            object o = System.Activator.CreateInstance(t, null);
            ((Form)o).ShowDialog();
        }
 
    }
}
