using Newtonsoft.Json;

//making sure to put in verbose properties and then using JsonPropety to bind
public class Company{
    public string Name { get; set; }
    public string CatchPhrase { get; set; }

    [JsonProperty(PropertyName = "bs")]
    public string Basics {get; set; }
}