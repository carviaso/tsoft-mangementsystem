
namespace TS.Business.FA.Dao
{
    partial class FaCostDao
    {
        private static string SQL_MAIN_ALL = 
            "select fc.cGUID,fc.cCode,fc.dDate,sup.cName cSupply,acc.cName cSettleAcct,sttype.cName cSettleType,fc.cSettleCode,fc.iAmt,fc.cBank,fc.cBankAcct,CASE WHEN fc.cAuditor is NULL THEN '未审核' ELSE '已审核' END cAuditStatus,u1.cName cAuditor,dAuditDate,dept.cName cDepartment,emp.cName cOperator,u2.cName cCreator,fc.cTimeStamp from Fa_CostList fc " +
            " left join CM_Supply sup on fc.cSupply = sup.cCode left join CM_Account acc on fc.cSettleAcct = acc.cCode left join CM_SettleType sttype on fc.cSettleType = sttype.cCode left join SYS_User u1 on fc.cAuditor = u1.cCode left join CM_Department dept on fc.cDepartment = dept.cCode left join CM_Employee emp on fc.cOperator = emp.cCode left join SYS_User u2 on fc.cCreator = u2.cCode";
        
        private static string SQL_SUB_ALL = 
            "select fcDetail.cCostType,fcDetail.iPayAmt,fcDetail.cRemark as cSubRemark from FA_CostDetail fcDetail";
        
        private static string SQL_LIST_ALL = 
            "select * from Fa_CostList fc ";
        
        private static string SQL_GUID_ALL = 
            "select cGUID from Fa_CostList "; 
    }
}
