using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Business.FA.Info
{
    public class FaRevenSubInfo : BusinessSubInfo
    {
        private object _cRevenType;
        private object _iRevenAmt;
        private object _cRemark;

        public Object cRevenType
        {
            get { return this._cRevenType; }
            set { this._cRevenType = value; }
        }

        public Object iRevenAmt
        {
            get { return this._iRevenAmt; }
            set { this._iRevenAmt = value; }
        }

        public Object cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }
    }
}
