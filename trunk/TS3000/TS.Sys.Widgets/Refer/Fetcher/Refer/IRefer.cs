using System;
using System.Windows.Forms; 
using TS.Sys.Widgets.Refer.GridRefer;
using TS.Sys.Widgets.Refer.WidgetRefer;

namespace TS.Sys.Widgets.Refer.Fetcher.Refer
{
    interface IRefer
    {
        /// <summary>
        /// 设置数据源
        /// </summary>
        /// <param name="grid"></param>
        void setDataSource(LabelRefer refer,String condition);

        void setGridDataSource(DataGridViewDataControlColumn col, String con);

        
        /// <summary>
        /// 获取条件的SQL
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        String getSql(String con);
    }
}
