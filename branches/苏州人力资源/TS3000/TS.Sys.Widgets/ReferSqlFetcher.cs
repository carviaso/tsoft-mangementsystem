using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace TS.Sys.Widgets
{
    class ReferSqlFetcher
    {
        private ReferSqlFetcher()
        {
           
        }
        
        /// <summary>
        /// 取职员cCode,cName,cDept
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static String getEmpInfoSql(String condition)
        {
            if (condition != "")
            {
                condition = " where cCode like '" + condition + "%'";
            }
            String sql = "select e.cGUID,e.cCode,e.cName,d.cName as cDept from BS_Employee e left join BS_Department d ON e.cDeptGUID = d.cGUID " + condition;
            return sql;
        }

        /// <summary>
        /// 取供应商cCode,cName,cShortName
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static String getSupInfoSql(String condition)
        {
            if (condition != "")
            {
                condition = " where cCode like '" + condition + "%'";
            }
            String sql = "select cGUID,cCode,cName,cShortName from BS_Supply " + condition;
            return sql;
        }

        /// <summary>
        /// 取物品的cCode,cName,cSpec
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static String getMatInfoSql(String condition)
        {
            if (condition != "")
            {
                condition = " where cCode like '" + condition + "%'";
            }
            String sql = "select m.cGUID as cMatGUID,m.cCode as cMatCode,m.cName as cMatName,m.cUnit,p.iPrice as iPrice from BS_Material m left join BS_MatPrice p on m.cGUID = p.cMatGUID" + condition;
            return sql;
        }

        /// <summary>
        /// 取物品的cCode,cName,cShortName
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static String getCustInfoSql(String condition)
        {
            if (condition != "")
            {
                condition = " where cCode like '" + condition + "%'";
            }
            String sql = "select cGUID,cCode,cName,cShortName from BS_Customer " + condition;
            return sql;
        }


        /// <summary>
        /// 取仓库的cCode,cName,cShortName
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static String getStInfoSql(String condition)
        {

            if (condition != "")
            {
                condition = " where cCode like '" + condition + "%'";
            }
            String sql = "select cGUID,cCode,cName,cShortName from BS_Store " + condition;
            return sql;
        }


        /// <summary>
        /// 取部门的cCode,cName,cShortName
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static String getDeptInfoSql(String condition)
        {
            if (condition != "")
            {
                condition = " where cCode like '" + condition + "%'";
            }
            String sql = "select cGUID,cCode,cName,cShortName from BS_Department " + condition;
            return sql;
        }

    }
}
