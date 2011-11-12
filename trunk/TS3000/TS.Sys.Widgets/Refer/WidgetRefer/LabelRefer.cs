using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Widgets.Refer.Control;

namespace TS.Sys.Widgets.Refer.WidgetRefer
{
    public partial class LabelRefer : UserControl
    {
        private Form _form;
        private Form _superForm;
        private ToolStripButton _btn;
        private String _url;
        private Object _tableName;

        public LabelRefer()
        {
            InitializeComponent();
        }

        public LabelRefer(Form form, ToolStripButton btn):this()
        {
            _form = form;
            _btn = btn;
        }


        /// <summary>
        /// 初始化参照的值
        /// </summary>
        /// <param name="referType"></param>
        private void initReferData(ReferType referType)
        {
            Type t = referType.GetType();
            String type = System.Enum.GetName(t, referType);
            if (_tableName == null)
            {
                _tableName = "CM_" + type;
            }
            String referForm = "TS.Forms.BusinessForm.BS." + type + "Form";
            _url = referForm;
            DataControl.DataFetcher = new DataFetcher(_tableName);
            DataControl.ReferForm = referForm;

        }

        public bool require;
        private RequireSelect _require;
        public enum RequireSelect
        {
            True,
            False,
        }
        [Browsable(true)]
        public String DataTableName
        {
            set { this._tableName =value; }
            get {
                if (this._tableName != null)
                    return this._tableName.ToString();
                else
                    return "";
                }
        }


        public RequireSelect Require
        {
            set
            {
                _require = value; 
                if (value == RequireSelect.True)
                {
                    require = true; 
                    //如果控件可用则用必填项的颜色，否则用不可用的颜色
                    if (dataControl.Enabled == true)
                    {
                        this.dataControl.BackColor = SystemColors.Info;
                    }
                }
                else
                {
                    require = false;
                    this.dataControl.BackColor = SystemColors.HighlightText;
                }

            }
            get { return this._require; }

        }

        private ReferType _referType;
        public ReferType DataType
        {
            set
            {
                this._referType = value;
                if (this._referType != 0)
                {
                    initReferData(this._referType);
                    
                }
            }
            get
            {
                return this._referType;
            }
        }
         
        /// <summary>
        /// 是否可用
        /// </summary>
        public new Boolean Enabled
        {
            set
            {
                this.dataControl.Enabled = value;
                this.pictureBox1.Enabled = value;
                if (!value)
                {
                    this.dataControl.BackColor = Color.MistyRose;
                }
                else
                {
                    this.dataControl.BackColor = SystemColors.HighlightText;
                }
            }
            get
            {
                return this.dataControl.Enabled;
            }
        }
        
        public String Label
        {
            set { this.label.Text = value; }
            get { return this.label.Text; }
        }

        [Browsable(false), Bindable(true)]
        public Object Value
        {
            set { this.dataControl.Value = value; }
            get { return this.dataControl.Value; }
        }

        public int LabelWidth
        {
            set
            {
                this.label.Width = value;
                this.tableLayoutPanel1.ColumnStyles[0].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[0].Width; }
        }

        public DataControl DataControl
        {
            get { return this.dataControl; }
        }

        public void SetInfoStatus(Form form, ToolStripButton btn)
        {
            _form = form;
            _btn = btn;
        }

        public void SetInfoStatus(Form form,Form superForm,ToolStripButton btn)
        {
            _form = form;
            _superForm = superForm;
            _btn = btn;
        }


        public void LocationChange()
        {
            DataControl.LocationChange();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.dataControl.ShowDropDown();
        }

        private void dataControl_Enter(object sender, EventArgs e)
        {
            this.pictureBox1.Enabled = true;
        }

        private void dataControl_Leave(object sender, EventArgs e)
        {
            this.pictureBox1.Enabled = false;
        }

      
          
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (_form != null && _btn != null)
            {
                SetReferType();
                if (_superForm != null)
                    SetSuperReferType();
                
            }
        }

        private void SetReferType()
        {
            Type t = _form.GetType();
            t.GetProperty("ReferType").SetValue(_form, _url, null);
            t.GetProperty("Args").SetValue(_form, new Object[] { this }, null);
            _btn.Enabled = true;
        }

        private void SetSuperReferType()
        {
            Type t = _superForm.GetType();
            t.GetProperty("ReferType").SetValue(_form, _url, null);
            t.GetProperty("Args").SetValue(_form, new Object[] { this }, null);
            _btn.Enabled = true;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (_form != null && _btn != null)
            {
                _btn.Enabled = false;
            }
        }

        private void dataControl_DoubleClick(object sender, EventArgs e)
        {  
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                Type t = _form.GetType();
                MethodInfo m = t.GetMethod("btnInfo_Click",BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
                //Object[] args = new Object[] { null,null};
                m.Invoke(_form, null);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("该窗口不存在");
            } 
        }

        private void tableLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                Type t = System.Type.GetType(_url);
                Object[] args = new Object[] { this };
                object o = System.Activator.CreateInstance(t, args);
                ((Form)o).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("该窗口不存在");
            } 
        }
    }
}
