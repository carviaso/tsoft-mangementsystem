using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.BaseData.Info
{
    public class BankInfo:BaseInfo
    {
        private object _cParent;

        public Object cParent
        {
            get { return this._cParent; }
            set { this._cParent = value; }
        }
    }
}
