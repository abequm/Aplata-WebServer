using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataApiService.Models
{
    public class Command
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("parameter_name1")]
        public string? ParameterName1 { get; set; }

        [JsonPropertyName("parameter_name2")]
        public string? ParameterName2 { get; set; }

        [JsonPropertyName("parameter_name3")]
        public string? ParameterName3 { get; set; }

        [JsonPropertyName("parameter_name4")]
        public string? ParameterName4 { get; set; }

        [JsonPropertyName("parameter_name5")]
        public string? ParameterName5 { get; set; }

        [JsonPropertyName("parameter_name6")]
        public string? ParameterName6 { get; set; }

        [JsonPropertyName("parameter_name7")]
        public string? ParameterName7 { get; set; }

        [JsonPropertyName("parameter_name8")]
        public string? ParameterName8 { get; set; }

        [JsonPropertyName("str_parameter_name1")]
        public string? StrParameterName1 { get; set; }

        [JsonPropertyName("str_parameter_name2")]
        public string? StrParameterName2 { get; set; }

        [JsonPropertyName("parameter_default_value1")]
        public int? ParameterDefaultValue1 { get; set; }

        [JsonPropertyName("parameter_default_value2")]
        public int? ParameterDefaultValue2 { get; set; }

        [JsonPropertyName("parameter_default_value3")]
        public int? ParameterDefaultValue3 { get; set; }

        [JsonPropertyName("parameter_default_value4")]
        public int? ParameterDefaultValue4 { get; set; }

        [JsonPropertyName("parameter_default_value5")]
        public int? ParameterDefaultValue5 { get; set; }

        [JsonPropertyName("parameter_default_value6")]
        public int? ParameterDefaultValue6 { get; set; }

        [JsonPropertyName("parameter_default_value7")]
        public int? ParameterDefaultValue7 { get; set; }

        [JsonPropertyName("parameter_default_value8")]
        public int? ParameterDefaultValue8 { get; set; }

        [JsonPropertyName("str_parameter_default_value1")]
        public string? StrParameterDefaultValue1 { get; set; }

        [JsonPropertyName("str_parameter_default_value2")]
        public string? StrParameterDefaultValue2 { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; }
    }
}
