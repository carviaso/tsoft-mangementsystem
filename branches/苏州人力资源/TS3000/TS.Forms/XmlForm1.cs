using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Widgets.Refer.GridRefer;
using TS.Sys.Widgets.Money.GridMoney;

using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using TS.Business.FA.Service;


namespace TS.Forms
{
    public partial class XmlForm1 : Form
    {
        public XmlForm1()
        {
            InitializeComponent();
            FaCostService a = new FaCostService();
            this.dataGridView1.DataSource = a.QueryForAll();
            this.dataGridView1.Rows[0].Frozen = true;
            this.dataGridView1.Columns[0].Frozen = true;
        }
        Excel.Range range;


        public void test()
        {
           
            string path2 = @"D:\excel2\";
            DirectoryInfo dinfo = new DirectoryInfo(path2);
            if (dinfo.Exists)
            { }
            else
                dinfo.Create();

            Excel.Application xApp = new Excel.Application();
            xApp.Application.Workbooks.Add(true);
            xApp.Visible = true;
            Excel.Worksheet xSheet = (Excel.Worksheet)xApp.ActiveSheet;
            string FileName = DateTime.Today.ToString("yyyyMMdd") + new Random(DateTime.Now.Millisecond).Next(10000).ToString();//文件格式为当前日期+4位随机数
            // string FileName = dataGridView1.Rows[0].Cells[1].Value.ToString();
            int row = 2, fieldcount, i = 0, col = 0;
            fieldcount = dataGridView1.RowCount - 1;
            xSheet.Cells[1, 1] = "编号";
            xSheet.Cells[1, 2] = "服务单位";
            xSheet.Cells[1, 3] = "联系人";
            xSheet.Cells[1, 4] = "服务地址";
            xSheet.Cells[1, 5] = "服务时间";
            xSheet.Cells[1, 6] = "总金额";
            for (int k = 0; k < 6; k++)
            {
                range = (Excel.Range)xSheet.Cells[1, k + 1];
                range.Interior.ColorIndex = 15;
                range.Font.Bold = true;
            }

            for (int j = 0; j < fieldcount - 1; j++)
            {

                for (col = 0; col < 9; col++)
                {
                    if (col == 0 || col == 1 || col == 2)
                        xSheet.Cells[row, col + 1] = dataGridView1.Rows[i].Cells[col + 1].Value.ToString();
                    else if (col == 4)
                        xSheet.Cells[row, col] = dataGridView1.Rows[i].Cells[col + 1].Value.ToString();
                    
                    else if (col == 8)
                        xSheet.Cells[row, col - 2] = dataGridView1.Rows[i].Cells[col + 1].Value.ToString() + "元";

                }
                row++;
                i++;
            }
            
            xSheet.PageSetup.TopMargin = 10;//上边距

            xSheet.PageSetup.BottomMargin = 3;//下

            xSheet.PageSetup.LeftMargin = 60;//左 
            xSheet.PageSetup.HeaderMargin = 10;//页眉 
            xSheet.PageSetup.FooterMargin = 3;//页脚 
            try
            {
                xSheet.SaveAs(path2 + FileName + ".xls",
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                MessageBox.Show(this, "Excel文件已经生成。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xApp.Quit();
                xApp = null;
            }
            catch (Exception Mye)
            {
                MessageBox.Show(this, Mye.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                GC.Collect();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            test();
        }

    }
}
