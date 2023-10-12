using System.Collections.Generic;
using System.Text;

using Microsoft.AspNetCore.Mvc.Filters;

namespace WebServer.Models
{
    public class CommandActionParameters
    {
        public string terminal_Id { get; set; }
        public int command_Id { get; set; }
        public int? parameter1 { get; set; }
        public int? parameter2 { get; set; }
        public int? parameter3 { get; set; }
    }
    public static class CommandsActionParametersExtention
    {
        /// <summary>
        /// Конвертер данныхиз параметров в объект
        /// </summary>
        /// <remarks>
        /// убирает null
        /// </remarks>
        /// <param name="pars">Параметры</param>
        /// <returns>Словарь</returns>
        public static string ToBodyString(this CommandActionParameters pars)
        {
            var result = new Dictionary<string, string>();
            //Перебираем свойства
            foreach (var propertyInfo in pars.GetType().GetProperties())
            {
                //Значение текущего свойства
                var value = propertyInfo.GetValue(pars);
                //Если значение есть, т.е. не null, не пустая строка, тогда берем
                if (value != null && !string.IsNullOrEmpty(value.ToString()))
                {
                    result.Add(propertyInfo.Name, propertyInfo.GetValue(pars).ToString());
                }
            }
            StringBuilder str = new StringBuilder();
            str.Append("{");
            foreach(var key in result.Keys)
            {
                str.Append($"\"{key}\"");
                str.Append($":");
                str.Append($"\"{result[key]}\"");
                str.Append($",");
            }
            str.Remove(str.Length - 1, 1);
            str.Append($"}}");
            return str.ToString();
        }
    }
}
