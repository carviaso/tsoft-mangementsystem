using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class UserDao:BaseDao
    {
        private static string SQL_ALL = "select user.cGUID,user.cCode,user.cName from CM_User user  ";
        private static string SQL_ALL_DETAIL = "select * from CM_User user";
        private static string TABLE = "CM_User";

        public UserDao()
        {
            base.TableName = TABLE;
        }

        public void AddUser(UserInfo userInfo)
        {
             Add(userInfo);
        }

        public void ModifyUser(UserInfo userInfo)
        {
             Modify(userInfo);
        }

        public void DeleteUser(UserInfo userInfo)
        {
             Delete(userInfo);
        }

        public void ForbiddenUser(UserInfo userInfo)
        {
             Forbidden(userInfo);
        }

        public void ValueableUser(UserInfo userInfo)
        {
             Valueable(userInfo);
        }         

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            String sql = SQL_ALL_DETAIL + con;
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

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            String sql = SQL_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }  
    }
}
