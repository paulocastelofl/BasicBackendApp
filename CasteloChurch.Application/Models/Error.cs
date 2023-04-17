using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace CasteloChurch.Application.Models
{
    public class Error
    {
        [JsonProperty(PropertyName = "status")]
        public int StatusCode { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; } = string.Empty;
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
