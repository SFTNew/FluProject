using FluCreate.log;
using FluCreate.task.job;
using FluCreate.utils;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace FluCreate.task
{
    class TaskClient
    {

        private Logger logger;
        private IScheduler scheduler;
        private NameValueCollection props;
        private StdSchedulerFactory factory;
        private string cron;
        private IJobDetail mzzyJob;
        private IJobDetail cyxjJob;
        private IJobDetail cylgbaJob;
        private IJobDetail swjlJob;
        private IJobDetail jyjlJob;
        private IJobDetail yyjlJob;
        private bool isFirst=true;
        private IJobDetail allJob;

        public LogType LoggerType { get; private set; }

        public TaskClient()
        {
            logger = Logger.Instance;
            props = new NameValueCollection
            {
                { "quartz.serializer.type", "binary" }
            };
            factory = new StdSchedulerFactory(props);
            
        }

        public async Task Run()
        {
            try
            {
                scheduler = await factory.GetScheduler();
                // 开启调度器
                await scheduler.Start();
                allJob = JobBuilder.Create<AllJob>()
                      .WithIdentity("allJob", "AllGroup")
                      .Build();
                ITrigger mzzyTrigger = TriggerBuilder.Create()
                    .WithIdentity("allTrigger", "AllGroup")
                    .StartNow()
                    .WithCronSchedule(cron)
                    .Build();
                await scheduler.ScheduleJob(allJob, mzzyTrigger);
                logger.WriteLog("定时任务启动成功");

            }
            catch(Exception ex)
            {
                logger.WriteException(ex);
            }
        }

        /**
         * 开启全部job 任务
         */
        public async Task RunTaskJob()
        {
            if (isFirst)
            {
                try
                {
                    scheduler = await factory.GetScheduler();
                    // 开启调度器
                    await scheduler.Start();


                    // 门诊和在院
                    mzzyJob = JobBuilder.Create<MZHZYJob>()
                        .WithIdentity("mzhzyJob", "MzzyGroup")
                        .Build();
                    ITrigger mzzyTrigger = TriggerBuilder.Create()
                        .WithIdentity("mzhzyTrigger", "MzzyGroup")
                        .StartNow()
                        .WithCronSchedule(cron)
                        .Build();

                    //出院小结
                    cyxjJob = JobBuilder.Create<CYXJJob>()
                       .WithIdentity("cyxjJob", "CyxjGroup")
                       .Build();
                    ITrigger cyxjTrigger = TriggerBuilder.Create()
                        .WithIdentity("cyxjTrigger", "CyxjGroup")
                        .StartNow()
                        .WithCronSchedule(cron)
                        .Build();

                    //出院流感病案
                    cylgbaJob = JobBuilder.Create<CYLGBAJob>()
                      .WithIdentity("cylgbaJob", "FluGroup")
                      .Build();

                    ITrigger cylgbaTrigger = TriggerBuilder.Create()
                        .WithIdentity("cylgbaTrigger", "FluGroup")
                        .StartNow()
                        .WithCronSchedule(cron)
                        .Build();

                    //死亡记录
                    swjlJob = JobBuilder.Create<SWJLJob>()
                        .WithIdentity("swjlJob", "SwjlGroup")
                        .Build();

                    ITrigger swjlJrigger = TriggerBuilder.Create()
                        .WithIdentity("swjlTrigger", "SwjlGroup")
                        .StartNow()
                        .WithCronSchedule(cron)
                        .Build();


                    //检验记录
                    jyjlJob = JobBuilder.Create<JYJLJob>()
                       .WithIdentity("jyjlJob", "JyjlGroup")
                       .Build();

                    ITrigger jyjlTrigger = TriggerBuilder.Create()
                        .WithIdentity("jyjlTrigger", "JyjlGroup")
                        .StartNow()
                        .WithCronSchedule(cron)
                        .Build();

                    //用药记录
                    yyjlJob = JobBuilder.Create<YYJLjob>()
                      .WithIdentity("yyjlJob", "YYjlGroup")
                      .Build();

                    ITrigger yyjlTrigger = TriggerBuilder.Create()
                        .WithIdentity("yyjlTrigger", "YYjlGroup")
                        .StartNow()
                        .WithCronSchedule(cron)
                        .Build();

                    // 告诉Quartz使用我们的触发器来安排作业
                    await scheduler.ScheduleJob(yyjlJob, yyjlTrigger);
                    await scheduler.ScheduleJob(jyjlJob, jyjlTrigger);
                    await scheduler.ScheduleJob(swjlJob, swjlJrigger);
                    await scheduler.ScheduleJob(cylgbaJob, cylgbaTrigger);
                    await scheduler.ScheduleJob(cyxjJob, cyxjTrigger);
                    await scheduler.ScheduleJob(mzzyJob, mzzyTrigger);

                    StopAllJob();
                    isFirst = false;
                    RunAllJob();
                    logger.WriteLog("定时任务启动成功");
                }
                catch (Exception ex)
                {
                    logger.WriteException(ex);
                }
            }
            else
            {
                //RunAllJob();
            }
          
        }

        public async Task ShutDown()
        {
            //await Task.Delay(TimeSpan.FromSeconds(60));// 等待60秒
            // 关闭调度程序
            await scheduler.Shutdown();
        }


        public  void RunAllJob()
        {
            bool  mzhzyCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "mzhzy", "true"));
            bool cyxjCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "cyxj", "true"));
            bool swjlCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "swjl", "true"));
            bool cylgblCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "cylgbl", "true"));
            bool jyjlCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "jyjl", "true"));
            cron = OperateIniFile.read("TASK", "cron", "0 0 23 ? * SUN");//默认是每个星期天晚上十一点钟生成
            bool yyjlCheck = Convert.ToBoolean(OperateIniFile.read("TASK", "yyjl", "true"));
            if (!mzhzyCheck)
            {
                scheduler.PauseJob(mzzyJob.Key);
            }
            if (cylgblCheck)
            {
                scheduler.PauseJob(cylgbaJob.Key);
            }
            if (swjlCheck)
            {
                scheduler.PauseJob(swjlJob.Key);
            }
            if (jyjlCheck)
            {
                scheduler.PauseJob(jyjlJob.Key);
            }
            if (cyxjCheck)
            {
                scheduler.PauseJob(cyxjJob.Key);
            }

            if (yyjlCheck)
            {
                scheduler.PauseJob(yyjlJob.Key);
            }
           
        }


        public void StopAllJob()
        {
            scheduler.PauseAll();
            logger.WriteLog("停止定时任务成功");
        }
    }
}
