using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.Business.FA.Dao;
using TS.Business.FA.Info;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Info; 

namespace TS.Business.FA.Service
{
    public class FaRevenService :AbstractBusinessService
    {
        private FaRevenDao faRevenDao;

        public FaRevenService()
        {
            faRevenDao = new FaRevenDao();
            base.Daos = faRevenDao;
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override Result Add(BusinessMainInfo bmi)
        {
            FaRevenInfo frInfo = (FaRevenInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            SqlCommand command = faRevenDao.GetAddMainCommand(frInfo);
            commands.Add(command);
            foreach (FaRevenSubInfo fdi in frInfo.RevenDetail)
            {
                command = faRevenDao.GetAddSubCommand(frInfo, fdi);
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
            FaRevenInfo frInfo = (FaRevenInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(faRevenDao.GetDelMainCommandFaReven(frInfo));
            commands.Add(faRevenDao.GetDelSubCommandFaReven(frInfo));
            return DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override Result Audit(BusinessMainInfo bmi)
        {
            FaRevenInfo frInfo = (FaRevenInfo)bmi;
            return faRevenDao.Audit(frInfo);
        }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override Result UnAudit(BusinessMainInfo bmi)
        {
            FaRevenInfo frInfo = (FaRevenInfo)bmi;
            return faRevenDao.UnAudit(frInfo);
        }

        /// <summary>
        /// 修改费用支出单
        /// 1、修改费用支出单主表
        /// 2、删除原费用子表数据
        /// 3、添加新费用子表数据
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public override Result Modify(BusinessMainInfo bmi)
        {
            FaRevenInfo frInfo = (FaRevenInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(faRevenDao.GetModifyCommand(frInfo));
            commands.Add(faRevenDao.GetDelSubCommandFaReven(frInfo));
            foreach (FaRevenSubInfo fdi in frInfo.RevenDetail)
            {
                commands.Add(faRevenDao.GetAddSubCommand(frInfo, fdi));
            }
            return DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        public ArrayList GetResultByGUID(object cGUID)
        {
            return faRevenDao.GetResultByGUID(cGUID);
        }

        public ArrayList GetForAllGUID()
        {
            return faRevenDao.GetForAllGUID();
        }

        public DataTable QueryForAll()
        {
            return faRevenDao.QueryForAll();
        }

        public DataTable QuerySubByGUID(object cGUID)
        {
            return faRevenDao.QuerySubByGUID(cGUID);
        }
    }
}
