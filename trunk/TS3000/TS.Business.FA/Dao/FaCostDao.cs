using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using TS.Business.FA.Info;
using TS.Sys.DBLayer;
using TS.Sys.Domain; 
using TS.Sys.Platform.Business.Dao;

namespace TS.Business.FA.Dao
{
    public class FaCostDao:BusinessDao
    {
        private static string SQL_MAIN_ALL = "select fc.cGUID,fc.cCode,fc.dDate,sup.cName cSupply,acc.cName cSettleAcct,sttype.cName cSettleType,fc.cSettleCode,fc.iAmt,fc.cBank,fc.cBankAcct,CASE WHEN fc.cAuditor is NULL THEN '未审核' ELSE '已审核' END cAuditStatus,u1.cName cAuditor,dAuditDate,dept.cName cDepartment,emp.cName cOperator,u2.cName cCreator,fc.cTimeStamp from Fa_CostList fc " +
            " left join CM_Supply sup on fc.cSupply = sup.cCode left join CM_Account acc on fc.cSettleAcct = acc.cCode left join CM_SettleType sttype on fc.cSettleType = sttype.cCode left join CM_User u1 on fc.cAuditor = u1.cCode left join CM_Department dept on fc.cDepartment = dept.cCode left join CM_Employee emp on fc.cOperator = emp.cCode left join CM_User u2 on fc.cCreator = u2.cCode";
        private static string SQL_SUB_ALL = "select fcDetail.cCostType,fcDetail.iPayAmt,fcDetail.cRemark as cSubRemark from FA_CostDetail fcDetail";
        private static string SQL_LIST_ALL = "select * from Fa_CostList fc ";
        private static string SQL_GUID_ALL = "select cGUID from Fa_CostList "; 
        private static string MAIN_TABLE = "FA_CostList";
        private static string SUB_TABLE = "FA_CostDetail";

        public FaCostDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(FaCostInfo fi)
        {
            AddMain(fi);
        }

        public void addSub(FaCostInfo fi, FaCostSubInfo fdi)
        {
            AddSub(fi, fdi);
        }

        public Result AuditFaCost(FaCostInfo fi)
        {
            return Audit(fi);
            
        }

        public Result UnAuditFaCost(FaCostInfo fi)
        {
            return UnAudit(fi);
        }
       
        public SqlCommand GetAddMainCommandFaCost(FaCostInfo fi)
        {
            return GetAddMainCommand(fi);
        }

        public SqlCommand GetAddSubCommandFaCost(FaCostInfo fi, FaCostSubInfo fdi)
        {
            return GetAddSubCommand(fi, fdi);
        }

        public SqlCommand GetDelMainCommandFaCost(FaCostInfo fi)
        {
            return GetDelMainCommand(fi);
        }

        public SqlCommand GetDelSubCommandFaCost(FaCostInfo fi)
        {
            return GetDelSubCommand(fi);
        }

        public SqlCommand GetModifyCommandFaCost(FaCostInfo fi)
        {
            return GetModifyCommand(fi);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }

        /// <summary>
        /// 根据cGUID查询
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public ArrayList GetResultByGUID(object cGUID)
        {
            if (cGUID != null)
            {
                cGUID = " where fc.cGUID = '" + cGUID+"'";
            }
            return GetResultList(cGUID);
        }

        public ArrayList GetForAllGUID()
        {
            ArrayList result = DbSvr.GetDbService().GetListResult(SQL_GUID_ALL);
            return result;
        }

        /// <summary>
        /// 根据条件查询结果集 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetValidatation(Hashtable con)
        {
            ArrayList result = DbSvr.GetDbService().GetExitsResult(MAIN_TABLE, con);
            return result;
        }

        public ArrayList GetForAll()
        {
            return GetResultList(null);
        }

        public ArrayList GetSubResult(object cGUID)
        {
            if (cGUID != null)
            {
                cGUID = " where fcDetail.cHeadGUID = '" + cGUID + "'";
            }
            return GetResultList(cGUID);
        }
        
        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            String sql = SQL_LIST_ALL + con;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable QueryForAll()
        {
            return GetDataTable(null);
        }

        public DataTable QuerySubByGUID(object cGUID)
        {
            if (cGUID != null)
            {
                cGUID = " where fcDetail.cHeadGUID = '" + cGUID + "'";
            }
            return GetSubDataTable(cGUID);
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetSubDataTable(object con)
        {
            String sql = SQL_SUB_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }
        
        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            String sql = SQL_MAIN_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }
        
        
    }
}
