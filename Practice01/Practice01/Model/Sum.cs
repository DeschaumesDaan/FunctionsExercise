using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Practice01.Model
{
    public class Sum
    {
        [JsonProperty(PropertyName = "number1")]
        public int Getal1 { get; set; }

        [JsonProperty(PropertyName = "number2")]
        public int Getal2 { get; set; }
    }
}
