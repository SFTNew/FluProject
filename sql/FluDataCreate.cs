using FluCreate.log;
using FluCreate.utils;
using HLHTUpLoad.common;
using System;
using System.Data;

namespace FluCreate.sql
{
    class FluDataCreate
    {
        private string fluUrl;
        private string hqmsUrl;
        private string backUpUrl;
        private SQLClient sqlClient;
        private Logger log;

        public FluDataCreate()
        {
            this.hqmsUrl = OperateIniFile.read("FILESAVEPATH", "hqms", "");
            this.fluUrl = OperateIniFile.read("FILESAVEPATH", "flu", "");
            this.backUpUrl = OperateIniFile.read("FILESAVEPATH", "backUp", "");
            sqlClient = new SQLClient();
            log = Logger.Instance;
        }

        public bool CreateCYXJ(string start,string end,out string msg)
        {
            try
            {
                log.WriteLog("查询" + start + "-" + end + "出院小结数据");
                log.WriteLog(SqlStr.CyxjSql(start, end));
                DataTable data = sqlClient.ExecuteQuery(SqlStr.CyxjSql(start, end),CommandType.Text);
                if (data.Rows.Count < 0)
                {
                    msg = "无出院小结记录\n";
                }
                else
                {
                    CSVUtil.SaveCSV(data, fluUrl + "\\hda_出院小结" + start + "-" + end + ".csv");
                    CSVUtil.SaveCSV(data, backUpUrl + "\\hda_出院小结" + start + "-" + end + ".csv");
                    msg  = "出院小结记录已生成\n";
                }
                log.WriteLog("查询成功");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                log.WriteLog("查询失败:" + ex.Message, LogType.Error);
                return false;
            }
            return true;
        }

        public bool CreateMZHZY(string start,string end,out string msg)
        {
            try
            {
                //执行两个门诊病案存储过程
                sqlClient.ExecuteSP(SqlStr.MZ_MZLGFY);
                sqlClient.ExecuteSP(SqlStr.MZ_MZLGPELBLE);
                log.WriteLog("查询" + start + "-" + end + "门诊和在院流感数据");
                log.WriteLog(SqlStr.MzhzySql(start, end));
                DataTable data = sqlClient.ExecuteQuery(SqlStr.MzhzySql(start, end), CommandType.Text);
                if (data.Rows.Count < 0)
                {
                    msg = "无门诊和在院流感数据\n";
                }
                else
                {
                    CSVUtil.SaveCSV(data, fluUrl + "\\flu_门诊和在院流感" + start+"-"+end+".csv");
                    CSVUtil.SaveCSV(data, backUpUrl + "\\flu_门诊和在院流感" + start + "-" + end + ".csv");
                    msg = "门诊和在院流感数据生成成功\n";
                }
                log.WriteLog("查询成功");
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                log.WriteLog("查询失败:" + ex.Message, LogType.Error);
                return false;
            }
            return true;
        }

        public bool CreateSWJL(string start, string end, out string msg)
        {
            try
            {
                log.WriteLog("查询" + start + "-" + end + "死亡记录数据");
                log.WriteLog(SqlStr.SwjlSql(start, end));
                DataTable data = sqlClient.ExecuteQuery(SqlStr.SwjlSql(start, end), CommandType.Text);
                if (data.Rows.Count < 0)
                {
                    msg = "无死亡记录数据\n";
                }
                else
                {
                    CSVUtil.SaveCSV(data, fluUrl + "\\hdr_死亡记录" + start + "-" + end + ".csv");
                    CSVUtil.SaveCSV(data, backUpUrl + "\\hdr_死亡记录" + start + "-" + end + ".csv");
                    msg = "死亡记录数据生成成功\n";
                }
                log.WriteLog("查询成功");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                log.WriteLog("查询失败:" + ex.Message, LogType.Error);
                return false;
            }
            return true;
        }


        public bool CreateCYLGBL(string start, string end, out string msg)
        {
            try
            {
                log.WriteLog("查询" + start + "-" + end + "出院流感病历数据");
                log.WriteLog(SqlStr.CylgblSql(start, end));
                DataTable data = sqlClient.ExecuteQuery(SqlStr.CylgblSql(start, end), CommandType.Text);
                if (data.Rows.Count < 0)
                {
                    msg = "无出院流感病历数据\n";
                }
                else
                {
                    CSVUtil.SaveCSV(data, hqmsUrl + "\\hqms_出院流感病历" + start + "-" + end + ".csv");
                    CSVUtil.SaveCSV(data, backUpUrl + "\\hqms_出院流感病历" + start + "-" + end + ".csv");
                    msg = "出院流感病历生成成功\n";
                }
                log.WriteLog("查询成功");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                log.WriteLog("查询失败:" + ex.Message, LogType.Error);
                return false;
            }
            return true;
        }


        public bool CreateJYJL(string start, string end, out string msg)
        {
            try
            {
                log.WriteLog("查询" + start + "-" + end + "检验记录数据");
                log.WriteLog(SqlStr.JyjlSql(start, end));
                DataTable data = sqlClient.ExecuteQuery(SqlStr.JyjlSql(start, end), CommandType.Text);
                if (data.Rows.Count < 0)
                {
                    msg = "无检验记录数据\n";
                }
                else
                {
                    CSVUtil.SaveCSV(data, fluUrl + "\\lis_检验记录" + start + "-" + end + ".csv");
                    CSVUtil.SaveCSV(data, backUpUrl + "\\lis_检验记录" + start + "-" + end + ".csv");
                    msg = "检验记录数据生成成功\n";
                }
                log.WriteLog("查询成功");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                log.WriteLog("查询失败:" + ex.Message, LogType.Error);
                return false;
            }
            return true;
        }

        public bool CreateYYJL(string start, string end, out string msg)
        {
            try
            {
                log.WriteLog("查询" + start + "-" + end + "用药记录数据");
                log.WriteLog(SqlStr.YyjlSql(start, end));
                DataTable data = sqlClient.ExecuteQuery(SqlStr.YyjlSql(start, end), CommandType.Text);
                if (data.Rows.Count < 0)
                {
                    msg = "无用药记录数据\n";
                }
                else
                {
                    CSVUtil.SaveCSV(data, fluUrl + "\\pdr_用药记录" + start + "-" + end + ".csv");
                    CSVUtil.SaveCSV(data, backUpUrl + "\\pdr_用药记录" + start + "-" + end + ".csv");
                    msg = "用药记录数据生成成功\n";
                }
                log.WriteLog("查询成功");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                log.WriteLog("查询失败:"+ex.Message,LogType.Error);
                return false;
            }
            return true;
        }
    }
}
