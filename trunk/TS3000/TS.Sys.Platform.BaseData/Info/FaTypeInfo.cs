using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class FaTypeInfo : BaseInfo
    {
        private object _cFullName;
        private object _cAcctCode;
        private object _iType;
        private object _iForbidden = 0;

        public Object iType
        {
            set { this._iType = value; }
            get { return this._iType; }
        }

        public Object cAcctCode
        {
            set { this._cAcctCode = value; }
            get { return this._cAcctCode; }
        }

        public Object iForbidden
        {
            set { this._iForbidden = value; }
            get { return this._iForbidden; }
        }

        public Object cFullName
        {
            set { this._cFullName = value; }
            get { return this._cFullName; }
        }
    }
}
