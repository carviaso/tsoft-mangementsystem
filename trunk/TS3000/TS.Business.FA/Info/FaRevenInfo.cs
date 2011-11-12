using System;
using System.Collections.Generic; 
using TS.Sys.Platform.Business.Info;

namespace TS.Business.FA.Info
{
    public class FaRevenInfo : BusinessMainInfo
    {
        private object _dDate;
        private object _cCreator;
        private object _cDepartment;
        private object _cOperator;
        private object _cRemark;
        private object _iAmt;
        private object _cSettleAcct;
        private object _cSettleType;
        private object _cSettleCode;
        private object _cCustomer;
        private object _cAuditor;
        private object _dAuditDate;
        private object _cCurrency;
        private List<FaRevenSubInfo> _RevenDetail;

        public FaRevenInfo()
        {
            _RevenDetail = new List<FaRevenSubInfo>();
        }

        public object dDate
        {
            get { return this._dDate; }
            set { this._dDate = value; }
        }

        public object cCreator
        {
            get { return this._cCreator; }
            set { this._cCreator = value; }
        }

        public object cDepartment
        {
            get { return this._cDepartment; }
            set { this._cDepartment = value; }
        }

        public object cOperator
        {
            get { return this._cOperator; }
            set { this._cOperator = value; }
        }

        public object cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }

        public object iAmt
        {
            get { return this._iAmt; }
            set { this._iAmt = value; }
        }

        public Object cCustomer
        {
            get { return this._cCustomer; }
            set { this._cCustomer = value; }
        }

        public Object cSettleAcct
        {
            get { return this._cSettleAcct; }
            set { this._cSettleAcct = value; }
        }

        public Object cSettleType
        {
            get { return this._cSettleType; }
            set { this._cSettleType = value; }
        }

        public Object cSettleCode
        {
            get { return this._cSettleCode; }
            set { this._cSettleCode = value; }
        }

        public Object cAuditor
        {
            get { return this._cAuditor; }
            set { this._cAuditor = value; }
        }

        public Object dAuditDate
        {
            get { return this._dAuditDate; }
            set { this._dAuditDate = value; }
        }

        public Object cCurrency
        {
            get { return this._cCurrency; }
            set { this._cCurrency = value; }
        }

        public List<FaRevenSubInfo> RevenDetail
        {
            get { return this._RevenDetail; }
            set { this._RevenDetail = value; }
        }

        public void AddSubReven(FaRevenSubInfo fcSub)
        {
            _RevenDetail.Add(fcSub);
        }
    }
}
