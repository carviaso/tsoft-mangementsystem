using System;
using System.Drawing;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets
{
    public partial class LabelEdit : UserControl
    {
        private bool _requireFlag;
        private RequireSelect _require;
        public enum RequireSelect
        {
            True,
            False,
        }

        public LabelEdit()
        {
            InitializeComponent();
           
        }

       
        
        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Label
        {
            set { this.label.Text = value; }
            get { return this.label.Text; }
        }

        public Boolean IsRequire
        {
            get { return this._requireFlag; }
        }

        
 
        /// <summary>
        /// �Ƿ������
        /// </summary>
        public  RequireSelect Require
        {
            set
            {
                if (value == RequireSelect.True)
                {
                    _requireFlag = true;
                    //����ؼ��������ñ��������ɫ�������ò����õ���ɫ
                    if (textBox.Enabled == true)
                    {
                        this.textBox.BackColor = SystemColors.Info;
                    }
                }
                else
                {
                    _requireFlag = false;
                    if(!_requireFlag&&!Enabled)
                    this.textBox.BackColor = SystemColors.HighlightText;
                }

            }
            get
            {
                if (_requireFlag)
                {
                    return RequireSelect.True;
                }
                else
                {
                    return RequireSelect.False;
                }
            }
            
        }

        /// <summary>
        /// �ؼ��Ƿ����
        /// </summary>
        public Boolean Enabled
        {
            set
            {
                this.textBox.Enabled = value;
                if (!value)
                {
                    this.textBox.BackColor = Color.MistyRose;
                }
                else
                {
                    this.textBox.BackColor = SystemColors.HighlightText;
                }
            }
            get
            {
                return this.textBox.Enabled;
            }
        }
        
        public Label LabelCtrl
        {
            get { return this.label; }
        }

        public Object Value
        {
            set {
                if (value != null)
                {
                    this.textBox.Text = value.ToString();
                }
                else
                {
                    this.textBox.Text = "";
                }
            }
            get { return this.textBox.Text; }
        }
       
        public TextBox TextBox
        {
            get { return this.textBox; }
        }


        /// <summary>
        /// ���ñ�ǩ���
        /// </summary>
        public int LabelWidth
        {
            set
            {
                this.label.Width = value;
                this.tableLayoutPanel1.ColumnStyles[0].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[0].Width; }
        }

        /// <summary>
        /// �����������
        /// </summary>
        public int TextWidth
        {
            set
            {
                this.textBox.Width = value;
                this.tableLayoutPanel1.ColumnStyles[1].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[1].Width; }
        }

        /// <summary>
        /// �Զ����¼���TextBoxKeyDown�¼�
        /// </summary>
        public event EventHandler TextBoxKeyPress;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxKeyPress != null)
                TextBoxKeyPress(this, e); 
        }


    }
}
