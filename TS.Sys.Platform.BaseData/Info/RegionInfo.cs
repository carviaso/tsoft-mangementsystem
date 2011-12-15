using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class RegionInfo : BaseInfo
    {
        private object _cParent;
        public Object cParent
        {
            get { return this._cParent; }
            set { this._cParent = value; }
        }
    
    }
}
