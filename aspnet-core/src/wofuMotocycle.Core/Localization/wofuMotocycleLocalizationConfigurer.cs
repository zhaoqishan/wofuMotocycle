using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace wofuMotocycle.Localization
{
    public static class wofuMotocycleLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(wofuMotocycleConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(wofuMotocycleLocalizationConfigurer).GetAssembly(),
                        "wofuMotocycle.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
