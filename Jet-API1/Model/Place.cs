﻿using Jet_API1.Model.Base;
using System.Text.Json.Serialization;

namespace Jet_API1.Model
{
    public class Place : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        [JsonIgnore]
        public City City { get; set; }
    }
}