using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using TS.Sys.DBLayer;

namespace TS.Sys.Widgets
{
    public partial class DataTree : UserControl
    {
        public DataTree()
        {
            InitializeComponent();
            
           
        }

        private string table;

        /// <summary>
        /// ��ȡ����
        /// </summary>
        public string Table
        {
            set { this.table = value; }
            get { return this.table; }
        }

        private string sql;

        /// <summary>
        /// SQLȡֵ��
        /// </summary>
        public string SqlFetcher
        {
            set { this.sql = value; }
            get { return this.sql; }
        }

        /// <summary>
        /// �������
        /// </summary>
        private bool active;
        private ActiveSelection activeSelect;
        public enum ActiveSelection
        {
            False,
            True,
        }

       
        public ActiveSelection Active
        {
            set
            {
                activeSelect = value;
                if (value == ActiveSelection.True)
                {
                    active = true;
                    
                }
                else
                {
                   // treeView.Nodes.Clear();
                    active = false;
                }
                 

            }
            get { return this.activeSelect; }

        }

        private TreeNode selectedNode;
        public TreeNode GetSelectedNode()
        {
            return this.selectedNode;
        }

        public void setAcitve(bool flag)
        {
            this.active = flag;
        }

        /// <summary>
        /// ͨ�����������ڵ� 
        /// </summary>
        /// <param name="rootTitle"></param>
        public void loadTreeDataByTable(string rootTitle)
        {
            TreeNode[] n = TreeFetcher("select cGUID,cCode,cName,cParent from " + this.table + " where cParent='{0}'","000000");
            treeView.ImageList = image_tree;
            try
            {
                TreeNode root = new TreeNode(rootTitle, n);
                root.Name = "000000";
                treeView.Nodes.Add(root);

            }
            catch (ArgumentNullException e)
            {

            }
        }

        /// <summary>
        /// ͨ��SQL�������ڵ�
        /// </summary>
        /// <param name="rootTitle"></param>
        public void loadTreeDataBySql(string rootTitle)
        {
            TreeNode[] n = TreeFetcher(this.sql,"000000");
            treeView.ImageList = image_tree;
            try
            {
                TreeNode root = new TreeNode(rootTitle, n);
                root.Name = "000000";
                treeView.Nodes.Add(root);

            }
            catch (ArgumentNullException e)
            {

            }
        }

        /// <summary>
        /// ����ȡֵ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private TreeNode[] TreeFetcher(string sql,string id)
        {

            ArrayList result = DbSvr.GetDbService().GetListResult(sql, new Object[] { id });
            if (result.Count == 0)
            {
                return null;
            }
            TreeNode[] nodes = new TreeNode[result.Count];
            int i = 0;
            foreach (Hashtable info in result)
            {

                String cCode = (string)info["cCode"];
                String cText = (string)info["cCode"] + " " + (string)info["cName"];//���ڵ��ı����� ����+����
                TreeNode[] childs = TreeFetcher(sql, cCode);
                if (childs != null)
                {
                    TreeNode node = new TreeNode(cText, childs);
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    node.Name = cCode;
                    nodes[i] = node;
                    i++;
                }
                else
                {
                    TreeNode node = new TreeNode(cText);
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                    node.Name = cCode;
                    nodes[i] = node;
                    i++;
                }


            }
            return nodes;

        }

        /// <summary>
        /// �Զ����¼���TextBoxKeyDown�¼�
        /// </summary>
        public event EventHandler AfterTreeNodeSelect;

        /// <summary>
        /// ˫��ʱ�����Ƿ�ΪҶ�ӽڵ��Լ��Ƿ�չ�����ı����ڵ��ͼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_DoubleClick(object sender, EventArgs e)
        {

            if (treeView.SelectedNode.IsExpanded && treeView.SelectedNode.ImageIndex != 2)
            {
                treeView.SelectedNode.SelectedImageIndex = 1;
            }
            else if (!treeView.SelectedNode.IsExpanded && treeView.SelectedNode.ImageIndex != 2)
            {
                treeView.SelectedNode.SelectedImageIndex = 0;
            }
        }

        /// <summary>
        /// ѡ���ʱ�����չ��״̬���Ƿ�Ҷ�ӽڵ��������ڵ��ͼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.IsExpanded && e.Node.ImageIndex != 2)
            {
                e.Node.SelectedImageIndex = 1;
            }
            else if (!e.Node.IsExpanded && e.Node.ImageIndex != 2)
            {
                e.Node.SelectedImageIndex = 0;
            }
            this.selectedNode = e.Node;
            if (AfterTreeNodeSelect != null)
                AfterTreeNodeSelect(this, e);
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
      

    }
}
