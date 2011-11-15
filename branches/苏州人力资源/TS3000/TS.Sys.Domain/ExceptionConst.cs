using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.Sys.Domain
{
    public class ExceptionConst
    {

        #region 系统错误
        /// <summary>
        /// 您输入了无效的数字，请重新输入！
        /// </summary>
        public static string Error_Number = "您输入了无效的数字，请重新输入！";
        #endregion
        /// <summary>
        /// 该单据已经被并发修改，请刷新！
        /// </summary>
        public static string Error_TimeStamp = "该单据已经被并发修改，请刷新！";
        /// <summary>
        /// 操作失败，该单据已经审核！
        /// </summary>
        public static string Error_Audit = "操作失败，该单据已经审核！";
        /// <summary>
        /// 操作失败，该单据未审核！
        /// </summary>
        public static string Error_UnAudit = "操作失败，该单据未审核！";
        /// <summary>
        /// 操作失败，该记录已禁用！
        /// </summary>
        public static string Error_Forbidden = "操作失败，该记录已禁用！";
        /// <summary>
        /// 操作失败，该记录已启用！
        /// </summary>
        public static string Error_Valueable = "操作失败，该记录已启用！";
    }
}
