using System; 
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class AccountInfo:BaseInfo
    {
        private object _cShortCode;
        private object _cParent;

        public Object cParent
        {
            get { return this._cParent; }
            set { this._cParent = value; }
        }
        public Object cShortCode
        {
            get { return this._cShortCode; }
            set { this._cShortCode = value; }
        }
    }
}
