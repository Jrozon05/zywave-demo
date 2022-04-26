using System.Collections.Generic;
using zywave_data.Model;

namespace zywave_data.Interfaces
{
    public interface IEmailFilterService
    {
        EmailFilter FilterEmail(List<string> classifiedWords, string emailText);
    }
}