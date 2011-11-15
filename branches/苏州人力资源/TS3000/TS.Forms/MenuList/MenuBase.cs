
using System.Windows.Forms;
using TS.Forms.BusinessForm.BS;
namespace TS.Forms.MenuList
{
    /// <summary>
    /// 基础设置菜单项
    /// </summary>
    public class MenuBase : TableLayoutPanel
    {
        private MainForm _mainForm;
        private System.Windows.Forms.LinkLabel btnAccount;
        private System.Windows.Forms.LinkLabel btnSettleType;
        private System.Windows.Forms.LinkLabel btnFaType;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel btnCustomer;
        private System.Windows.Forms.LinkLabel btnSupply;
        private System.Windows.Forms.LinkLabel btnEmployee;
        private System.Windows.Forms.LinkLabel btnDepartment;
        private System.Windows.Forms.LinkLabel btnBankAcct;
        private System.Windows.Forms.LinkLabel btnRegion;
        private System.Windows.Forms.LinkLabel btnUser;
        private System.Windows.Forms.LinkLabel btnCsgl;

        public MenuBase(MainForm mainForm)
        {
            this._mainForm = mainForm;           
            this.btnCustomer = new System.Windows.Forms.LinkLabel();
            this.btnSupply = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnFaType = new System.Windows.Forms.LinkLabel();
            this.btnSettleType = new System.Windows.Forms.LinkLabel();
            this.btnAccount = new System.Windows.Forms.LinkLabel();
            this.btnDepartment = new System.Windows.Forms.LinkLabel();
            this.btnEmployee = new System.Windows.Forms.LinkLabel();
            this.btnBankAcct = new System.Windows.Forms.LinkLabel();
            this.btnRegion = new System.Windows.Forms.LinkLabel();
            this.btnUser = new System.Windows.Forms.LinkLabel();
            this.btnCsgl = new System.Windows.Forms.LinkLabel();
            initComponent();

        }
         

        public void initComponent()
        {
            // 
            // tpBase
            // 
            this.Controls.Clear();
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ColumnCount = 6;
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.Controls.Add(this.btnCustomer, 1, 1);
            this.Controls.Add(this.btnSupply, 0, 1);
            this.Controls.Add(this.linkLabel1, 3, 0);
            this.Controls.Add(this.btnFaType, 2, 0);
            this.Controls.Add(this.btnSettleType, 1, 0);
            this.Controls.Add(this.btnAccount, 0, 0);
            this.Controls.Add(this.btnDepartment, 1, 2);
            this.Controls.Add(this.btnEmployee, 0, 2);
            this.Controls.Add(this.btnBankAcct, 2, 1);
            this.Controls.Add(this.btnRegion, 3, 1);
            this.Controls.Add(this.btnUser, 0, 3);
            this.Controls.Add(this.btnCsgl, 1, 3);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Location = new System.Drawing.Point(183, 113);
            this.Name = "MenuContext";
            this.RowCount = 5;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Size = new System.Drawing.Size(812, 600);
            this.TabIndex = 1;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCustomer.Image = global::TS.Forms.Properties.Resources.Customer;
            this.btnCustomer.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnCustomer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCustomer.LinkColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(182, 163);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 85);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.TabStop = true;
            this.btnCustomer.Text = "客户";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseCompatibleTextRendering = true;
            // 
            // btnSupply
            // 
            this.btnSupply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSupply.Image = global::TS.Forms.Properties.Resources.Supply;
            this.btnSupply.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnSupply.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnSupply.LinkColor = System.Drawing.Color.Black;
            this.btnSupply.Location = new System.Drawing.Point(52, 160);
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.Size = new System.Drawing.Size(75, 91);
            this.btnSupply.TabIndex = 6;
            this.btnSupply.TabStop = true;
            this.btnSupply.Text = "供应商";
            this.btnSupply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupply.UseCompatibleTextRendering = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Image = global::TS.Forms.Properties.Resources.Price;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(442, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 80);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "商品价格库";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnFaType
            // 
            this.btnFaType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaType.Image = global::TS.Forms.Properties.Resources.FaType;
            this.btnFaType.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.btnFaType.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnFaType.LinkColor = System.Drawing.Color.Black;
            this.btnFaType.Location = new System.Drawing.Point(322, 45);
            this.btnFaType.Name = "btnFaType";
            this.btnFaType.Size = new System.Drawing.Size(65, 80);
            this.btnFaType.TabIndex = 2;
            this.btnFaType.TabStop = true;
            this.btnFaType.Text = "收支类别";
            this.btnFaType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnFaType_LinkClicked);
            // 
            // btnSettleType
            // 
            this.btnSettleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettleType.Image = global::TS.Forms.Properties.Resources.SettleType;
            this.btnSettleType.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.btnSettleType.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnSettleType.LinkColor = System.Drawing.Color.Black;
            this.btnSettleType.Location = new System.Drawing.Point(192, 45);
            this.btnSettleType.Name = "btnSettleType";
            this.btnSettleType.Size = new System.Drawing.Size(65, 80);
            this.btnSettleType.TabIndex = 1;
            this.btnSettleType.TabStop = true;
            this.btnSettleType.Text = "结算方式";
            this.btnSettleType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettleType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSettleType_LinkClicked);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.Image = global::TS.Forms.Properties.Resources.account;
            this.btnAccount.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.btnAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnAccount.LinkColor = System.Drawing.Color.Black;
            this.btnAccount.Location = new System.Drawing.Point(62, 45);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(65, 80);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.TabStop = true;
            this.btnAccount.Text = "会计科目";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAccount_LinkClicked);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDepartment.Image = global::TS.Forms.Properties.Resources.Department;
            this.btnDepartment.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnDepartment.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnDepartment.LinkColor = System.Drawing.Color.Black;
            this.btnDepartment.Location = new System.Drawing.Point(182, 326);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(75, 85);
            this.btnDepartment.TabIndex = 10;
            this.btnDepartment.TabStop = true;
            this.btnDepartment.Text = "部门";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.UseCompatibleTextRendering = true;
            this.btnDepartment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDepartment_LinkClicked);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmployee.Image = global::TS.Forms.Properties.Resources.Employee;
            this.btnEmployee.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnEmployee.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnEmployee.LinkColor = System.Drawing.Color.Black;
            this.btnEmployee.Location = new System.Drawing.Point(52, 326);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(75, 85);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.TabStop = true;
            this.btnEmployee.Text = "职员";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseCompatibleTextRendering = true;
            // 
            // btnBankAcct
            // 
            this.btnBankAcct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBankAcct.Image = global::TS.Forms.Properties.Resources.Bank;
            this.btnBankAcct.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnBankAcct.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnBankAcct.LinkColor = System.Drawing.Color.Black;
            this.btnBankAcct.Location = new System.Drawing.Point(312, 163);
            this.btnBankAcct.Name = "btnBankAcct";
            this.btnBankAcct.Size = new System.Drawing.Size(75, 85);
            this.btnBankAcct.TabIndex = 11;
            this.btnBankAcct.TabStop = true;
            this.btnBankAcct.Text = "账户管理";
            this.btnBankAcct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBankAcct.UseCompatibleTextRendering = true;
            // 
            // btnRegion
            // 
            this.btnRegion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegion.Image = global::TS.Forms.Properties.Resources.Region;
            this.btnRegion.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnRegion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnRegion.LinkColor = System.Drawing.Color.Black;
            this.btnRegion.Location = new System.Drawing.Point(442, 163);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(75, 85);
            this.btnRegion.TabIndex = 12;
            this.btnRegion.TabStop = true;
            this.btnRegion.Text = "地区管理";
            this.btnRegion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegion.UseCompatibleTextRendering = true;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUser.Image = global::TS.Forms.Properties.Resources.User;
            this.btnUser.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnUser.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnUser.LinkColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(52, 482);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 85);
            this.btnUser.TabIndex = 13;
            this.btnUser.TabStop = true;
            this.btnUser.Text = "用户管理";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseCompatibleTextRendering = true;
            // 
            // btnCsgl
            // 
            this.btnCsgl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCsgl.Image = global::TS.Forms.Properties.Resources.SysOption;
            this.btnCsgl.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.btnCsgl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCsgl.LinkColor = System.Drawing.Color.Black;
            this.btnCsgl.Location = new System.Drawing.Point(182, 482);
            this.btnCsgl.Name = "btnCsgl";
            this.btnCsgl.Size = new System.Drawing.Size(75, 85);
            this.btnCsgl.TabIndex = 14;
            this.btnCsgl.TabStop = true;
            this.btnCsgl.Text = "参数管理";
            this.btnCsgl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCsgl.UseCompatibleTextRendering = true;
        }


        private void btnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountForm acc = new AccountForm();
            acc.MdiParent = _mainForm;
            _mainForm.AddForm();
            acc.Show();
        }

        private void btnSettleType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettleTypeForm settle = new SettleTypeForm();
            settle.MdiParent = _mainForm;
            _mainForm.AddForm();
            settle.Show();
        }

        private void btnDepartment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartmentForm dept = new DepartmentForm();
            dept.MdiParent = _mainForm;
            _mainForm.AddForm();
            dept.Show();
        }

        private void btnFaType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FaTypeForm faType = new FaTypeForm();
            faType.MdiParent = _mainForm;
            _mainForm.AddForm();
            faType.Show();
        }
    }

    
}
