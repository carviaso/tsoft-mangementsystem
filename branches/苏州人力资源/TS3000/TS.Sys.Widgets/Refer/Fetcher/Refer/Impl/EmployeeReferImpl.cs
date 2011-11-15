using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Widgets.Refer.WidgetRefer;
using System.Data;
using TS.Sys.Widgets.Refer.GridRefer;

namespace TS.Sys.Widgets.Refer.Fetcher.Refer.Impl
{
    public class EmployeeReferImpl:BaseRefer
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
                con = " where emp.cCode like '" + con + "%'";
            }
            String sql = "select emp.cCode,emp.cName from CM_Employee emp  " + con;
            return sql;
        }
    }
}
