using System;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Tree;
using TS.PRS.MemberMan.Adapter;

namespace TS_PRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode a = new TreeNode("adsf");
            this.treeView1.Nodes.Add(a);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberAdapter a = new MemberAdapter();
           // a.SyncMember();
        }
    }
}
