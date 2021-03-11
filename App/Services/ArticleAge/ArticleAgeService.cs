using System.Text;
using System.Collections.Generic;
using System;
using App.Models.ViewModels;
using App.Services.ArticleAge.Interfaces;

namespace App.Services.ArticleAge
{
    public class ArticleAgeService : IArticleAgeService
    {
        public string CountMyAge(ArticleVM articleVM)
        {
            if(articleVM.LastModified == null)
            {
                return "No date available";
            }

            DateTime now = DateTime.Now;
            DateTime lastModification = (DateTime)articleVM.LastModified;

            TimeSpan span = now.Subtract(lastModification);

            return ProcessDates(span);
        }

        private string ProcessDates(TimeSpan span)
        {
            StringBuilder result = new StringBuilder();

            IDictionary<string, int> timeUnits = new Dictionary<string, int>()
            {
                {"days", span.Days},
                {"hours", span.Hours},
                {"minutes", span.Minutes}
            };

            foreach(string key in timeUnits.Keys)
            {
                int currentValue = timeUnits[key]; 
                
                if ( currentValue > 0)
                {
                    string timeUnit = (!key.Equals("minutes")) ? $"{currentValue} {key}, " : $"{currentValue} {key} ";
                    result.Append(timeUnit);
                }
            }

            result.Append("ago.");

            return result.ToString();
        } 
    }
}