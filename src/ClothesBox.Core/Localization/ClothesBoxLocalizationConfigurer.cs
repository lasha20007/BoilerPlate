using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ClothesBox.Localization
{
    public static class ClothesBoxLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ClothesBoxConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ClothesBoxLocalizationConfigurer).GetAssembly(),
                        "ClothesBox.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
