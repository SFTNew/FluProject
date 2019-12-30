using FluCreate.log;
using FluCreate.sql;
using FluCreate.utils;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluCreate.task
{
    class MZHZYJob : IJob
    {
        private Logger logger = Logger.Instance;
        private bool isFrist = true;

        public Task Execute(IJobExecutionContext context)
        {
            FluDataCreate fluData = new FluDataCreate();
            string startTime="";
            string endTime = DateTime.Now.ToString("yyyy-MM-dd");
            if (isFrist)
            {
                startTime = OperateIniFile.read("TASK", "startTime", "");
                OperateIniFile.write("TASK", "nextStartTime", endTime);
                isFrist = false;
            }
            else
            {
                startTime = OperateIniFile.read("TASK", "nextStartTime", "");
                OperateIniFile.write("TASK", "startTime", endTime);
                isFrist = true;
            }
            string msg;
            fluData.CreateMZHZY(startTime, endTime,out msg);
            //logger.WriteLog(startTime + "---" + endTime + "生成门诊和在院流感记录成功");
           
            return Task.CompletedTask;
        }
    }
}
