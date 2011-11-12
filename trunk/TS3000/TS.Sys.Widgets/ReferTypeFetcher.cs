using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Widgets
{
    public class ReferTypeFetcher
    {
        public  static Form _form;
        public static void SetType(Form form)
        {
            _form = form;
        }

        public String SetReferTypeByCode(String type,String condition)
        {
            String sql = "";
            if (type == "supply")
            {//��Ӧ��
                sql = "select cGUID,cCode,cName from BS_Supply where cCode='" + condition + "'";
            }
            else if (type == "employee")
            {//ְԱ
                sql = "select cGUID,cCode,cName from BS_Employee where cCode='" + condition + "'";
            }
            else if (type == "customer")
            {//�ͻ�
                sql = "select cGUID,cCode,cName from BS_Customer where cCode='" + condition + "'";
            }
            else if (type == "store")
            {//�ֿ�
                sql = "select cGUID,cCode,cName from BS_Store where cCode='" + condition + "'";
            }
            else if (type == "department")
            {//����
                sql = "select cGUID,cCode,cName from BS_Department where cCode='" + condition + "'";
            }
            else if (type == "account")
            {
                sql = "select cGUID,cCode,cName from CM_AccountDetail where cCode='" + condition + "'";
            }

            return sql;
        }

        public String SetReferTypeByGUID(String type, String condition)
        {
            String sql = "";
            if (type == "supply")
            {//��Ӧ��
                sql = "select cGUID,cCode,cName from BS_Supply where cGUID='" + condition + "'";
            }
            else if (type == "employee")
            {//ְԱ
                sql = "select cGUID,cCode,cName from BS_Employee where cGUID='" + condition + "'";
            }
            else if (type == "customer")
            {//�ͻ�
                sql = "select cGUID,cCode,cName from BS_Customer where cGUID='" + condition + "'";
            }
            else if (type == "store")
            {//�ֿ�
                sql = "select cGUID,cCode,cName from BS_Store where cGUID='" + condition + "'";
            }
            else if (type == "department")
            {//����
                sql = "select cGUID,cCode,cName from BS_Department where cGUID='" + condition + "'";
            }
            return sql;
        }
    }
}
