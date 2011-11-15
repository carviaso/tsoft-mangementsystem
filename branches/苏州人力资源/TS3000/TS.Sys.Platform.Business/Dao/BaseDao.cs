using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.Business.Dao
{
    public class BaseDao : Daos
    {

        protected void Add(Infos info)
        {
            Hashtable field = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            info.cGUID = cGUID;
            info.cTimeStamp = cTimeStamp;
            DbSvr.GetDbService().Insert(TableName, info);
            
        }

        protected void Modify(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            info.cTimeStamp = cTimeStamp;
            DbSvr.GetDbService().Update(TableName, info, con);
            
        }

        protected void Delete(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Result result = new Result();
            DbSvr.GetDbService().Delete(TableName, con);
        }

        protected void Forbidden(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Hashtable values = new Hashtable();
            values.Add("iForbidden", 1);
            Result result = new Result();
            DbSvr.GetDbService().Update(TableName, values, con);
        }

        protected void Valueable(Infos info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Hashtable values = new Hashtable();
            values.Add("iForbidden", 0);
            Result result = new Result();
            DbSvr.GetDbService().Update(TableName, values, con);
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
