using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Forms.BusinessForm.FA;
using TS.Forms.BusinessForm.BS;

namespace TS.Forms.MenuListTest
{
    public partial class MenuFATest : Form
    {
        public MenuFATest()
        {
            InitializeComponent();
        }

        private MainForm _mainForm;

        public MenuFATest(MainForm mainForm):this()
        {
            _mainForm = mainForm;
        }

        private void btnCostList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CostListForm costList = new CostListForm();
            costList.MdiParent = _mainForm;
            _mainForm.AddForm();
            costList.Show();
        }

        private void btnCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForm cust = new CustomerForm();
            cust.MdiParent = _mainForm;
            _mainForm.AddForm();
            cust.Show();
        }

        private void cSupply_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplyForm sup = new SupplyForm();
            sup.MdiParent = _mainForm;
            _mainForm.AddForm();
            sup.Show();
        }

        private void btnFaType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FaTypeForm faType = new FaTypeForm();
            faType.MdiParent = _mainForm;
            _mainForm.AddForm();
            faType.Show();

        }

        private void btnFaRevenList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RevenListForm revenList = new RevenListForm();
            revenList.MdiParent = _mainForm;
            _mainForm.AddForm();
            revenList.Show();

        }
    }
}
