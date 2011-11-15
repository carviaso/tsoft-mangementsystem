using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Domain; 
using TS.Sys.Util;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.Business.Dao
{
    public class BaseDao : Daos
    {


        protected Result Add(Infos info)
        {
            Hashtable field = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            info.cGUID = cGUID;
            info.cTimeStamp = cTimeStamp;
            Result result = new Result();
            if (DbSvr.GetDbService().Insert(TableName, info) > 0)
            {
                result.Code = SysConst.exeSucess;
                result.Message = SysConst.insertSucess;
            }
            else
            {
                result.Code = SysConst.exeFaild;
                result.Message = SysConst.insertFaild;
            }
            return result;
        }

        protected Result Modify(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            info.cTimeStamp = cTimeStamp;
            Result result = new Result();
            if (DbSvr.GetDbService().Update(TableName, info, con) > 0)
            {
                result.Code = SysConst.exeSucess;
                result.Message = SysConst.modifySucess;
            }
            else
            {
                result.Code = SysConst.exeFaild;
                result.Message = SysConst.modifyFaild;
            }
            return result;
        }

        protected Result Delete(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Result result = new Result();
            if (DbSvr.GetDbService().Delete(TableName, con) > 0)
            {
                result.Code = SysConst.exeSucess;
                result.Message = SysConst.deleteSucess;
            }
            else
            {
                result.Code = SysConst.exeFaild;
                result.Message = SysConst.deleteFaild;
            }
            return result;
        }

        protected Result Forbidden(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Hashtable values = new Hashtable();
            values.Add("iForbidden", 1);
            Result result = new Result();
            if (DbSvr.GetDbService().Update(TableName, values, con) > 0)
            {
                result.Code = SysConst.exeSucess;
                result.Message = SysConst.forbidSuccess;
            }
            else
            {
                result.Code = SysConst.exeFaild;
                result.Message = SysConst.forbidFaild;
            }
            return result;
        }

        protected Result Valueable(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Hashtable values = new Hashtable();
            values.Add("iForbidden", 0);
            Result result = new Result();
            if (DbSvr.GetDbService().Update(TableName, values, con) > 0)
            {
                result.Code = SysConst.exeSucess;
                result.Message = SysConst.valueSucess;
            }
            else
            {
                result.Code = SysConst.exeFaild;
                result.Message = SysConst.valueFaild;
            }
            return result;
        }

        

        /// <summary>
        /// 根据条件查询结果集 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetValidatation(Hashtable con)
        {
            ArrayList result = DbSvr.GetDbService().GetExitsResult(TableName, con);
            return result;
        }
         
    }
}
