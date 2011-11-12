using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class RegionInfo : BaseInfo
    {
        private Object _iForbidden = 0;

        public Object iForbidden
        {
            get { return this._iForbidden; }
            set { this._iForbidden = value; }
        }
    }
}
