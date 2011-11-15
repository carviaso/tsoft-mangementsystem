using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
using TS.Sys.Util;

namespace TS.Sys.DBLayer
{
    public class DBConfig
    {
        private static System.Collections.Hashtable ht = new System.Collections.Hashtable();        
        
        private static void init()
        {
            //loadFromRegistery();
            loadFromXML();
        }

        private static void loadFromRegistery()
        {
            ht.Add("dataSource", RegisteryUtil.GetRegistData("DataSource"));
            ht.Add("initCataLog", RegisteryUtil.GetRegistData("InitCataLog"));
            ht.Add("username", RegisteryUtil.GetRegistData("Username"));
            ht.Add("password", RegisteryUtil.GetRegistData("Password"));
        }

        private static void loadFromXML()
        {
            //XmlDocument doc = new XmlDocument();
           // doc.Load("db.xml");

            ht.Add("dataSource","ICE-PC");// doc.SelectNodes("//db/DataSource").Item(0).InnerText);
            ht.Add("initCataLog", "TS3000");// doc.SelectNodes("//db/InitCatalog").Item(0).InnerText);
            ht.Add("username", "sa");//doc.SelectNodes("//db/Username").Item(0).InnerText);
            ht.Add("password","sa123456"); //doc.SelectNodes("//db/Password").Item(0).InnerText);
        }

        public static String getConfig(String key)
        {
            if (ht.Count == 0) init();
            return (string)ht[key];
        }
    }
}
