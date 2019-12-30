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
    class SWJLJob : IJob
    {
        private Logger logger = Logger.Instance;
        private bool isFrist = true;
        public Task Execute(IJobExecutionContext context)
        {
            FluDataCreate fluData = new FluDataCreate();
            string startTime = "";
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
            fluData.CreateSWJL(startTime, endTime, out msg);
            return Task.CompletedTask;
        }
    }
}
