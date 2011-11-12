using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.Sys.Widgets.Refer.Fetcher.Refer.Impl
{
    public class CustomerReferImpl : BaseRefer
    {


        /// <summary>
        /// 获取取数SQL
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public override String getSql(String con)
        {
            if (con != "" && con != null)
            {
                con = " where cust.cCode like '" + con + "%'";
            }
            String sql = "select cust.cCode,cust.cName from CM_Customer cust  " + con;
            return sql;
        }
    }
}
