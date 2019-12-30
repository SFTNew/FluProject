using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace FluCreate.utils
{
    class OperateIniFile
    {
        public static string iniFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\config.ini"; //string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        #region API函数声明
        [DllImport("kernel32", CharSet = CharSet.Unicode)]//返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]//返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion
        #region 读Ini文件
        public static string read(string Section, string Key, string defaultText)
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, defaultText, temp, 4096, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return defaultText;
            }
        }
        #endregion
        #region 写Ini文件
        public static bool write(string Section, string Key, string Value)
        {
            var pat = Path.GetDirectoryName(iniFilePath);
            if (Directory.Exists(pat) == false)
            {
                Directory.CreateDirectory(pat);
            }
            if (File.Exists(iniFilePath) == false)
            {
                File.Create(iniFilePath).Close();
            }
            long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
            if (OpStation == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
