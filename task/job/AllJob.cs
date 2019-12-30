using FluCreate.log;
using FluCreate.sql;
using FluCreate.utils;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluCreate.task.job
{
    class AllJob : IJob

    {
        //private Logger logger = Logger.Instance;
        public Task Execute(IJobExecutionContext context)
        {
            FluDataCreate fluData = new FluDataCreate();

            bool mzhzyCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "mzhzy", "true"));
            bool cyxjCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "cyxj", "true"));
            bool swjlCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "swjl", "true"));
            bool cylgblCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "cylgbl", "true"));
            bool jyjlCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "jyjl", "true"));
            //string cron = OperateIniFile.read("TASK", "cron", "0 0 23 ? * SUN");//默认是每个星期天晚上十一点钟生成
            bool yyjlCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "yyjl", "true"));
            string startTime = OperateIniFile.read("TASK", "startTime", "");
            string yesterday = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            string endTime = DateTime.Now.ToString("yyyy-MM-dd");
            
            string msg;
            if (mzhzyCheck)
            {
                fluData.CreateMZHZY(yesterday, endTime, out msg);
            }
            if (cyxjCheck)
            {
                fluData.CreateCYXJ(yesterday, endTime, out msg);
            }
            if (swjlCheck)
            {
                fluData.CreateSWJL(yesterday, endTime, out msg);
            }
            if (cylgblCheck)
            {
                fluData.CreateCYXJ(yesterday, endTime, out msg);
            }
            if (jyjlCheck)
            {
                fluData.CreateJYJL(yesterday, endTime, out msg);
            }
            if (yyjlCheck)
            {
                fluData.CreateYYJL(yesterday, endTime, out msg);
            }

            return Task.CompletedTask;
        }

    }
}
