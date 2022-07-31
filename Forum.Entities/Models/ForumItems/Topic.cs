using Newtonsoft.Json;

namespace Forum.Entities.Models.ForumItems
{
    public class Topic
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("Name")]

        public string Name { get; set; }


    }
}
