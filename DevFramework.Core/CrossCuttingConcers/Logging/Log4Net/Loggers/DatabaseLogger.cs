﻿using log4net;

namespace DevFramework.Core.CrossCuttingConcers.Logging.Log4Net.Loggers
{
    public class DatabaseLogger : LoggerService
    {
        public DatabaseLogger() : base(LogManager.GetLogger("DatabaseLogger"))
        {
        }
    }
}
