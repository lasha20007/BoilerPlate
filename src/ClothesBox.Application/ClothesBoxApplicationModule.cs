using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClothesBox.Authorization;

namespace ClothesBox
{
    [DependsOn(
        typeof(ClothesBoxCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ClothesBoxApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ClothesBoxAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ClothesBoxApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
