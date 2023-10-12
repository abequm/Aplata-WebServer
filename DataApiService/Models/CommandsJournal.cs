using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataApiService.Models
{
    public class CommandsJournal
    {
        [JsonPropertyName("terminal_id")]
        public int TerminalId { get; set; }

        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        [JsonPropertyName("command_id")]
        public int CommandId { get; set; }

        [JsonPropertyName("parameter1")]
        public int Parameter1 { get; set; }

        [JsonPropertyName("parameter2")]
        public int Parameter2 { get; set; }

        [JsonPropertyName("parameter3")]
        public int Parameter3 { get; set; }

        [JsonPropertyName("parameter4")]
        public int Parameter4 { get; set; }

        [JsonPropertyName("parameter5")]
        public int Parameter5 { get; set; }

        [JsonPropertyName("parameter6")]
        public int Parameter6 { get; set; }

        [JsonPropertyName("parameter7")]
        public int Parameter7 { get; set; }

        [JsonPropertyName("parameter8")]
        public int Parameter8 { get; set; }

        [JsonPropertyName("str_parameter1")]
        public string? StrParameter1 { get; set; }

        [JsonPropertyName("str_parameter2")]
        public string? StrParameter2 { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("state_name")]
        public string StateName { get; set; }

        [JsonPropertyName("time_created")]
        public string? TimeCreated { get; set; }

        [JsonPropertyName("time_delivered")]
        public string TimeDelivered { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
