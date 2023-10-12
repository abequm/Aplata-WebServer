namespace DataApiService.Models
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class Machine
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("number")]
        public object Number { get; set; }

        [JsonPropertyName("terminal_id")]
        public object TerminalId { get; set; }

        [JsonPropertyName("state_id")]
        public long StateId { get; set; }

        [JsonPropertyName("product_matrix_id")]
        public object ProductMatrixId { get; set; }

        [JsonPropertyName("daily_sales_sum")]
        public long DailySalesSum { get; set; }

        [JsonPropertyName("daily_sales_count")]
        public long DailySalesCount { get; set; }

        [JsonPropertyName("last_sale")]
        public string LastSale { get; set; }

        [JsonPropertyName("state_mask")]
        public long? StateMask { get; set; }

        [JsonPropertyName("micromarket")]
        public bool Micromarket { get; set; }

        [JsonPropertyName("product_matrix_version")]
        public long ProductMatrixVersion { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }
    }

    public partial class MachinesTotal
    {
        [JsonPropertyName("working")]
        public long Working { get; set; }

        [JsonPropertyName("failed")]
        public long Failed { get; set; }

        [JsonPropertyName("warning")]
        public long Warning { get; set; }
    }
}
