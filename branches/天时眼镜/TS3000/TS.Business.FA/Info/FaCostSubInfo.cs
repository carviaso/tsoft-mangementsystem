using System; 
using TS.Sys.Platform.Business.Info;

namespace TS.Business.FA.Info
{
    public class FaCostSubInfo:BusinessSubInfo
    {         
        private object _cCostType;
        private object _iPayAmt;
        private object _cRemark;

        public Object cCostType
        {
            get { return this._cCostType; }
            set { this._cCostType = value; }
        }

        public Object iPayAmt
        {
            get { return this._iPayAmt; }
            set { this._iPayAmt = value; }
        }

        public Object cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }

         
    }
}
