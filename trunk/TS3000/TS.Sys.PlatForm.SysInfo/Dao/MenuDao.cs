using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class MenuDao:BaseDao
    {
        private String _tableName = "Sys_Menu";


        /// <summary>
        /// con的条件格式必须为
        /// cField:Value
        /// cParent:Value
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(Hashtable con)
        {
            String sql = "select * from sys_menu m where m.cParent like '%" + con["cParent"] + "%' and m.cField ='" + con["cField"] + "'";
            return DbSvr.GetDbService().GetListResult(sql);
        }
    }
}
