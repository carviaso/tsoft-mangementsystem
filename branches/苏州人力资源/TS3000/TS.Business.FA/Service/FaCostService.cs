using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.Business.FA.Dao;
using TS.Business.FA.Info;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util; 


namespace TS.Business.FA.Service
{
    public class FaCostService:AbstractBusinessService
    {
        private FaCostDao faCostDao;

        public FaCostService()
        {
            faCostDao = new FaCostDao();
            base.Daos = faCostDao;
            
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override Result Add(BusinessMainInfo bmi)
        {
            FaCostInfo fcInfo = (FaCostInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            SqlCommand command = faCostDao.GetAddMainCommandFaCost(fcInfo);
            commands.Add(command);
            foreach (object o in fcInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                FaCostSubInfo fdi = new FaCostSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                command = faCostDao.GetAddSubCommandFaCost(fcInfo, fdi);
                commands.Add(command);
            }
            return DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 删除单据
        /// 删除主表
        /// 删除子表
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override Result Del(BusinessMainInfo bmi)
        {
            FaCostInfo fcInfo = (FaCostInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(faCostDao.GetDelMainCommandFaCost(fcInfo));
            commands.Add(faCostDao.GetDelSubCommandFaCost(fcInfo));
            return DbSvr.GetDbService().UpdateInTransaction(commands);            
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override Result Audit(BusinessMainInfo bmi)
        {
            FaCostInfo fcInfo = (FaCostInfo)bmi;
            return faCostDao.AuditFaCost(fcInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override Result UnAudit(BusinessMainInfo bmi)
        {
            FaCostInfo fcInfo = (FaCostInfo)bmi;
            return faCostDao.UnAuditFaCost(fcInfo);
        }

        /// <summary>
        /// 修改费用支出单
        /// 1、修改费用支出单主表
        /// 2、删除原费用子表数据
        /// 3、添加新费用子表数据
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public override Result Modify(BusinessMainInfo fi)
        {
            FaCostInfo fcInfo = (FaCostInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(faCostDao.GetModifyCommandFaCost(fcInfo));
            commands.Add(faCostDao.GetDelSubCommandFaCost(fcInfo));
            foreach (object o in (ArrayList)fcInfo.SubInfos)
            {
                FaCostSubInfo fdi = (FaCostSubInfo)o;
                commands.Add(faCostDao.GetAddSubCommandFaCost(fcInfo, fdi));
            }
            return DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        public ArrayList GetForAllGUID()
        {
            return faCostDao.GetForAllGUID();
        }

        public ArrayList GetForAll()
        {
            return faCostDao.GetForAll();
        }
         
        public DataTable QueryForAll()
        {
            return faCostDao.QueryForAll();
         }

        public DataTable QuerySubByGUID(object cGUID)
        {
            return faCostDao.QuerySubByGUID(cGUID);
        }


    }
}
