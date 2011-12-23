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
    public partial class FaRevenDao : BusinessDao
    {
        
        private static string MAIN_TABLE = "FA_RevenList";
        private static string SUB_TABLE = "FA_RevenDetail";

        public FaRevenDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
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
