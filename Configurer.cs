using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDotNet5
{
    internal class Configurer
    {
        private readonly IConfiguration configuration;
        //private readonly IOptions<AppSettingsModel> appSettings;

        public Configurer(IConfiguration _config)
        {
            configuration = _config;
        }
        //public Configurer(IOptions<AppSettingsModel> app)
        //{
        //    appSettings = app;
        //}
        public void DoWork()
        {
            //var keyValuePairs = configuration.AsEnumerable().ToList();
            var connectString = configuration.GetConnectionString("FurnitureContext");
            var ax = connectString;
        }
    }
}
