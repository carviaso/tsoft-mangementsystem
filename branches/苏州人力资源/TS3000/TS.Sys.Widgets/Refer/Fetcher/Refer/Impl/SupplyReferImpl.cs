using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; 
using TS.Sys.Widgets.Refer.WidgetRefer;
using TS.Sys.Widgets.Refer.GridRefer;

namespace TS.Sys.Widgets.Refer.Fetcher.Refer.Impl
{
    public class SupplyReferImpl:BaseRefer
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
                con = " where sup.cCode like '" + con + "%'";
            }
            String sql = "select sup.cCode,sup.cName from CM_Supply sup  " + con;
            return sql;
        }
    }
}
