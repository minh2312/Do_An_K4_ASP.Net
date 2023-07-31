using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace DoAN_k4.Models
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("fname")]
        public string FirstName { get; set; }

        [BsonElement("lname")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("about")]
        public string About { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("userImg")]
        public string UserImage { get; set; }

        [BsonElement("coverPicture")]
        public string CoverPicture { get; set; }

        [BsonElement("posts")]
        public string[] Posts { get; set; }

        [BsonElement("followers")]
        public string[] Followers { get; set; }

        [BsonElement("followings")]
        public string[] Followings { get; set; }

        [BsonElement("allmessages")]
        public string[] AllMessages { get; set; }

        [BsonElement("isAdmin")]
        public bool IsAdmin { get; set; }

        [BsonElement("status")]
        public bool Status { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [BsonIgnore]
        public int __v { get; set; }

    }
}
