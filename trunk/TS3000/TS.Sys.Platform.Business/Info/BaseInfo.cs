using System;  

namespace TS.Sys.Platform.Business.Info
{
    public class BaseInfo:Infos
    {

        private object _cCode;
        private object _cName;

        public Object cCode
        {
            get { return this._cCode; }
            set { this._cCode = value; }
        }

        public Object cName
        {
            get { return this._cName; }
            set { this._cName = value; }
        }
    }
}
