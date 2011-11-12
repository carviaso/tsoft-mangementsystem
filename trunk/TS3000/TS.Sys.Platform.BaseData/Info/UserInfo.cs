using System;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.BaseData.Info
{
    public class UserInfo:BaseInfo
    {
        private object _cEmployee;

        public Object cEmployee
        {
            get { return this._cEmployee; }
            set { this._cEmployee = value; }
        }
    }
}
