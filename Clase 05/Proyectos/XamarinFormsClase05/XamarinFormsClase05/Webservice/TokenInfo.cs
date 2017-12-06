using System;
using Newtonsoft.Json;
using PLAN.Model;

namespace PLAN
{
	public class TokenInfo: BaseModel
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = ".issued")]
        public DateTime Issued { get; set; }
        [JsonProperty(PropertyName = ".expires")]
        public string DateTime { get; set; }

      
        public bool Isvalid
        {
            get { return !string.IsNullOrEmpty(AccessToken); }
        }
    }
}