using Forum.Entities.Models.User;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Entities.Models.ForumItems
{
    public class Post
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        [JsonProperty("UserId")]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserInfo UserInfo { get; set; }

        [JsonProperty("TopicId")]
        public Guid TopicId { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
    }
}
