using System.Collections.Generic;

namespace zywave_data.Extensions
{
    public static class FilterExtensions
    {
        public static string ClassifiedText(List<string> classifiedWords, string filterText)
        {
            for (int i = 0; i < filterText.Length; ++i)
            {
                foreach (var classifiedWord in classifiedWords)
                {
                    if (filterText.CaseInsensitiveContains(classifiedWord))
                    {
                        string asteriks = new string('*', classifiedWord.Length);

                        filterText = filterText.ReplaceAt(classifiedWord, asteriks);
                    }
                }
            }

            return filterText;
        }
    }
}