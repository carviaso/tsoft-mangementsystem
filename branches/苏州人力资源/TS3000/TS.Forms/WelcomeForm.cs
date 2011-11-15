using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Forms.BusinessForm.BS;
using TS.Forms.MenuList;
using TS.Forms.BusinessForm.FA;
using System.Reflection;

namespace TS.Forms
{
    public partial class WelcomeForm : Form
    {
        private MainForm _mainForm;
        private String _modual;
        private String _defaulEvent = "btnPu_Click";
        private ToolStripButton preButton;
        private MenuContext _menuContext;

        public WelcomeForm()
        {
            InitializeComponent();
            
        }

        public WelcomeForm(MainForm mainForm)
            : this()
        {
            this._mainForm = mainForm;
            Type t = this.GetType();
            MethodInfo mi = t.GetMethod(_defaulEvent, BindingFlags.NonPublic | BindingFlags.Instance);
            object[] param = new object[] { null, null };
            mi.Invoke(this, param);
        }

        public String DefaultEvent
        {
            get { return this._defaulEvent; }
            set { this._defaulEvent = value; }
        }
        
        

        private void btnBase_Click(object sender, EventArgs e)
        {
            if (_modual != null && !_modual.Equals("base"))
            {
                this.tpControl.Controls.Remove(tpControl.Controls["MenuContext"]);
            }
            else if (_modual.Equals("base"))
            {
                return;
            }
            this._modual = "base";
            this.tpControl.Controls.Add(new MenuBase(_mainForm), 1, 2);
            if (preButton != null)
            {
                preButton.BackgroundImage = null;
                preButton.ForeColor = Color.White;
            }
            btnBase.BackgroundImage = global::TS.Forms.Properties.Resources.MenuSelectedBG;
            btnBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBase.ForeColor = System.Drawing.SystemColors.HotTrack;
            preButton = btnBase;
            
        }
        

        private void btnArAp_Click(object sender, EventArgs e)
        {
            String modual = "arap";
            CreatMenuContext(btnArAp,modual);
            preButton = btnArAp;
        }

        
        private void btnSa_Click(object sender, EventArgs e)
        {
            String modual = "sa";
            CreatMenuContext(btnSa,modual);
            preButton = btnSa;
            
        }

        private void btnPu_Click(object sender, EventArgs e)
        {
            String modual = "pu";
            CreatMenuContext(btnPu, modual);
            preButton = btnPu;
        }

        private void CreatMenuContext(ToolStripButton btn, String modual)
        {
            if (_modual != null && !_modual.Equals(modual))
            {
                this.tpControl.Controls.Remove(tpControl.Controls["MenuContext"]);
            }
            else if (_modual != null && _modual.Equals(modual))
            {
                return;
            }
            this._modual = modual;
            this._menuContext = new MenuContext(_mainForm, this._modual);
            this.tpControl.Controls.Add(_menuContext, 1, 2);
            if (preButton != null)
            {
                preButton.BackgroundImage = null;
                preButton.ForeColor = Color.White;
            }
            btn.BackgroundImage = global::TS.Forms.Properties.Resources.MenuSelectedBG;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.ForeColor = SystemColors.HotTrack;
        }      
         
         
    }
}
