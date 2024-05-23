using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TodosAppABP.Localization
{
    public static class TodosAppABPLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TodosAppABPConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TodosAppABPLocalizationConfigurer).GetAssembly(),
                        "TodosAppABP.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
