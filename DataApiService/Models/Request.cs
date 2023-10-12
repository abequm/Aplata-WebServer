using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataApiService.Models
{
    public class Request<T, P>
    {
        [JsonPropertyName("total")]
        public P Total { get; set; }

        [JsonPropertyName("page_number")]
        public long PageNumber { get; set; }

        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        [JsonPropertyName("items_count")]
        public long ItemsCount { get; set; }

        [JsonPropertyName("items")]
        public List<T> Items { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
