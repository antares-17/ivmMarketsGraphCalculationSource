using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using ivmMarkets.GraphCalculation.BuildingBlocks.Calculation;
using ivmMarkets.GraphCalculation.ServiceBase;
using ivmMarkets.GraphCalculation.Fe.API.Services;

namespace ivmMarkets.GraphCalculation.Fe.API
{
    public class Startup : StartupBase
    {
        protected override bool NeedValueChangedSubscription => true;

        public Startup(IConfiguration configuration) : base(configuration) { }

        protected override void ConfigureSettings(IServiceCollection services)
        {
            services.Configure<AppSettings>(Configuration);
        }

        protected override AppSettingsBase GetSettings(IServiceProvider sp)
        {
            return sp.GetRequiredService<IOptions<AppSettings>>().Value;
        }

        protected override void AddCustomServices(IServiceCollection services)
        {
            services.AddSingleton<ICalculationNode, CalculationNode>();
        }
    }
}
