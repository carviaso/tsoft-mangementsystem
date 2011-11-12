using System;
using System.Collections.Generic;
using System.Text;

namespace TS.Sys.Util
{
    public class KeyUtil
    {
        /// <summary>
        /// ����18λΨһID
        /// </summary>
        /// <returns></returns>
        public static String genSimpleKey()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return Convert.ToString(BitConverter.ToInt64(buffer, 0)).Substring(1);   
        }

        /// <summary>
        /// ���ɡ�ǰ׺+YYYYMMDD+��λ��������ı���
        /// </summary>
        /// <param name="prefix">ǰ׺</param>
        /// <returns></returns>
        public static String genSimpleCode(String prefix)
        {
            return (prefix==null?"":prefix) + DateTime.Now.ToString("yyyyMMdd") + new Random().Next(10, 100);
        }
    }
}
