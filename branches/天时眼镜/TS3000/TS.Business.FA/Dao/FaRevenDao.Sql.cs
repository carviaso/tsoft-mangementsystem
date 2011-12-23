
namespace TS.Business.FA.Dao
{
    partial class FaRevenDao
    {
        private static string SQL_MAIN_ALL = 
            "select fr.cGUID,fr.cCode,fr.dDate,cust.cName cCustomer,acc.cName cSettleAcct,sttype.cName cSettleType,fr.cSettleCode,fr.iAmt,fr.cBank,fr.cBankAcct,CASE WHEN fr.cAuditor is NULL THEN '未审核' ELSE '已审核' END cAuditStatus,u1.cName cAuditor,dAuditDate,dept.cName cDepartment,emp.cName cOperator,u2.cName cCreator from Fa_RevenList fr " +
            " left join CM_Customer cust on fr.cCustomer = cust.cCode left join CM_Account acc on fr.cSettleAcct = acc.cCode left join CM_SettleType sttype on fr.cSettleType = sttype.cCode left join SYS_User u1 on fr.cAuditor = u1.cCode left join CM_Department dept on fr.cDepartment = dept.cCode left join CM_Employee emp on fr.cOperator = emp.cCode left join SYS_User u2 on fr.cCreator = u2.cCode";
        
        private static string SQL_SUB_ALL = 
            "select frDetail.cRevenType,frDetail.iPayAmt,frDetail.cRemark as cSubRemark from FA_RevenDetail frDetail";
        
        private static string SQL_LIST_ALL = 
            "select * from Fa_RevenList fr ";
        
        private static string SQL_GUID_ALL = 
            "select cGUID from Fa_RevenList ";

    }
}
