using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TS.Sys.Widgets
{
    class LabelEditDataFetcher
    {
        public LabelEditDataFetcher(FlowLayoutPanel panel, DataTable db)
       {
           SetDataSource(panel,db);
       }
        
       private void SetDataSource(FlowLayoutPanel panel,DataTable db)
       {
           foreach (Control control in panel.Controls)
           {
               control.DataBindings.Add("text", db, control.Name);
           }
       }
    
    }
}
