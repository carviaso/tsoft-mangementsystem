using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class SettleTypeInfo : BaseInfo
    {
        private object _cAcctGUID;
        private object _iForbidden = 0;

        public Object cAcctGUID
        {
            get { return this._cAcctGUID; }
            set { this._cAcctGUID = value; }
        }

        public Object iForbidden 
        {
            get { return this._iForbidden; }
            set { this._iForbidden = value; }
        }
    
        
    }
}
