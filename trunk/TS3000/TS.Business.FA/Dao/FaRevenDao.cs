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
    public class FaRevenDao : BusinessDao
    {
        private static string SQL_MAIN_ALL = "select fr.cGUID,fr.cCode,fr.dDate,cust.cName cCustomer,acc.cName cSettleAcct,sttype.cName cSettleType,fr.cSettleCode,fr.iAmt,fr.cBank,fr.cBankAcct,CASE WHEN fr.cAuditor is NULL THEN '未审核' ELSE '已审核' END cAuditStatus,u1.cName cAuditor,dAuditDate,dept.cName cDepartment,emp.cName cOperator,u2.cName cCreator from Fa_RevenList fr " +
            " left join CM_Customer cust on fr.cCustomer = cust.cCode left join CM_Account acc on fr.cSettleAcct = acc.cCode left join CM_SettleType sttype on fr.cSettleType = sttype.cCode left join CM_User u1 on fr.cAuditor = u1.cCode left join CM_Department dept on fr.cDepartment = dept.cCode left join CM_Employee emp on fr.cOperator = emp.cCode left join CM_User u2 on fr.cCreator = u2.cCode";
        private static string SQL_SUB_ALL = "select frDetail.cRevenType,frDetail.iPayAmt,frDetail.cRemark as cSubRemark from FA_RevenDetail frDetail";
        private static string SQL_LIST_ALL = "select * from Fa_RevenList fr ";
        private static string SQL_GUID_ALL = "select cGUID from Fa_RevenList ";

        private static string MAIN_TABLE = "FA_RevenList";
        private static string SUB_TABLE = "FA_RevenDetail";

        public FaRevenDao()
        {
            base.TableName = MAIN_TABLE;
        }

        public void addMain(FaRevenInfo fi)
        {
            AddMain(fi);
        }

        public void addSub(FaRevenInfo fi, FaRevenSubInfo fdi)
        {
            AddSub(fi, fdi);
        }

        public Result Audit(object cGUID)
        {
            return Audit(cGUID);

        }

        public Result UnAudit(object cGUID)
        {
            return UnAudit(cGUID);
        }

        public SqlCommand GetAddMainCommand(FaRevenInfo fi)
        {
            return GetAddMainCommand(fi);
        }

        public SqlCommand GetAddSubCommand(FaRevenInfo fi, FaRevenSubInfo fdi)
        {
            return GetAddSubCommand(fi, fdi);
        }

        public SqlCommand GetDelMainCommandFaReven(FaRevenInfo fi)
        {
            return GetDelMainCommand(fi);
        }

        public SqlCommand GetDelSubCommandFaReven(FaRevenInfo fi)
        {
            return GetDelSubCommand(fi);
        }

        public SqlCommand GetModifyCommand(FaRevenInfo fi)
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
                cGUID = " where fr.cGUID = '" + cGUID + "'";
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

        public ArrayList GetForAllGUID()
        {
            ArrayList result = DbSvr.GetDbService().GetListResult(SQL_GUID_ALL);
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
                cGUID = " where frDetail.cHeadGUID = '" + cGUID + "'";
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
