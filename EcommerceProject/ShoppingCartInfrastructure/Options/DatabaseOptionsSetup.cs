using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
namespace ShoppingCart.Infrastructure.Options
{
    public class DatabaseOptionsSetup:IConfigureOptions<DatabaseOptions>
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _configuration;
        private const string _devConnection = "DevelopmentConnection";
        private const string _stagConnection = "StagingConnection";


        public DatabaseOptionsSetup(IHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }
        //3rd video 18:18, download iwebhostenvironment
        public void Configure(DatabaseOptions options)
        {
            if (_env.IsStaging() is true)
            {
                options.ConnectionString = _configuration.GetConnectionString("_stagConnection");
            }
            else if(e)
            {
                  
            }
        }
    }
}
