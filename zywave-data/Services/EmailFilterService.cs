using System.Collections.Generic;
using zywave_data.Extensions;
using zywave_data.Interfaces;
using zywave_data.Model;

namespace zywave_data.Services
{
    public class EmailFilterService : IEmailFilterService
    {
        public EmailFilter FilterEmail(List<string> classifiedWords, string emailText)
        {
            var emailFilter = new EmailFilter();

            emailText = StringExtensions.RemoveSpecialChars(emailText);
            var emailCensoredText = FilterExtensions.ClassifiedText(classifiedWords, emailText);
            emailFilter.isClassified = ContainsClassifiedWords(emailFilter, emailCensoredText);
            emailFilter.EmailText = emailFilter.isClassified ? emailCensoredText : emailText;

            return emailFilter;
        }

        private static bool ContainsClassifiedWords(EmailFilter emailFilter, string emailCensoredText)
        {
            bool isClassified = false;
            return isClassified = emailCensoredText.Contains("*") ? true : false;
        }
    }
}