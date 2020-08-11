using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleUI
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> log;
        private readonly IConfiguration config;

        /// <summary>
        /// Initialize service with DI to enable logging and configuration
        /// </summary>
        /// <param name="log">ILogger instance</param>
        /// <param name="config">IConfiguration instance</param>
        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            this.log = log;
            this.config = config;
        }
        public void Run()
        {
            for (int i = 0; i < config.GetValue<int>("LoopTimes"); i++)
            {
                //Do not use string interpolation when logging
                log.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
