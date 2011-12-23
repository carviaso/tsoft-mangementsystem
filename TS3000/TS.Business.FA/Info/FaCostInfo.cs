using System;
using System.Collections.Generic;
using TS.Sys.Platform.Business.Info; 

namespace TS.Business.FA.Info
{
    /// <summary>
    /// 费用
    /// </summary>
    public class FaCostInfo : BusinessMainInfo
    {
        private object _dDate;   
        
        private object _cDepartment;
        private object _cOperator;
        private object _cRemark;
        private object _iAmt;
        private object _cSettleAcct;
        private object _cSettleType;
        private object _cSettleCode;
        private object _cSupply;
        private object _cCurrency;
        private object _cBank;

        public FaCostInfo()
        {
             
        }

        public object dDate
        {
            get { return this._dDate; }
            set { this._dDate = value; }
        }

        public Object cBank
        {
            get { return this._cBank; }
            set { this._cBank = value; }
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

        public Object cSupply
        {
            get { return this._cSupply; }
            set { this._cSupply = value; }
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
        

        public Object cCurrency
        {
            get { return this._cCurrency; }
            set { this._cCurrency = value; }
        }

         
    }
}
