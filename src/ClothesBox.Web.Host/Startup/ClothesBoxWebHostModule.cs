using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClothesBox.Configuration;

namespace ClothesBox.Web.Host.Startup
{
    [DependsOn(
       typeof(ClothesBoxWebCoreModule))]
    public class ClothesBoxWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ClothesBoxWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClothesBoxWebHostModule).GetAssembly());
        }
    }
}
