using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace TS.Sys.Util
{
    public class RegisteryUtil
    {
        private static string companyName = "TSoft";
        //��ȡָ����·����ֵ
        public static string GetRegistData(string name)
        {
            object registData;
            RegistryKey hkml = Registry.LocalMachine;

            string[] a = hkml.GetSubKeyNames();

            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.OpenSubKey(companyName, true);
            registData = aimdir.GetValue(name);
            return registData!=null?registData.ToString():null;
        }
        //������ֵ
        public static void WTRegedit(string name, string tovalue)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.CreateSubKey(companyName);
            aimdir.SetValue(name, tovalue);
        }
        //ɾ��ָ��ֵ
        public static void DeleteRegist(string name)
        {
            string[] aimnames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.OpenSubKey(companyName, true);

            foreach (string aimKey in aimdir.GetValueNames())
            {
                if (aimKey == name)
                {
                    aimdir.DeleteValue(name);
                    return;
                }
            }

            aimnames = aimdir.GetSubKeyNames();
            foreach (string aimKey in aimnames)
            {
                if (aimKey == name)
                    aimdir.DeleteSubKeyTree(name);
            }
        }
        //�ж�ָ�����Ƿ����
        public static bool IsRegeditExit(string name)
        {
            bool _exit = false;
            string[] subkeyNames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.OpenSubKey(companyName, true);

            foreach (string keyName in aimdir.GetValueNames())
            {
                if (keyName == name)
                {
                    _exit = true;
                    return _exit;
                }
            }
            
            subkeyNames = aimdir.GetSubKeyNames();
            foreach (string keyName in subkeyNames)
            {
                if (keyName == name)
                {
                    _exit = true;
                    return _exit;
                }
            }
            return _exit;
        } 

    }
}
