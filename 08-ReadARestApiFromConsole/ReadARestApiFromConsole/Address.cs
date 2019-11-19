using Newtonsoft.Json;

//making sure to put in verbose properties and then using JsonPropety to bind
public class Address{
    public string Street { get; set; }
    public string Suite { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }

    [JsonProperty(PropertyName = "geo")]
    public Geostationary Geostationary { get; set; }
}