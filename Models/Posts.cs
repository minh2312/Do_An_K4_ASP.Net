using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DoAN_k4.Models
{
    [BsonIgnoreExtraElements]
    public class Posts
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("post")]
        public string PostContent { get; set; }

        [BsonElement("postImg")]
        public string[] PostImages { get; set; }

        [BsonElement("likes")]
        public string[] Likes { get; set; }

        [BsonElement("comments")]
        public Comment[] Comments { get; set; }

        [BsonElement("status")]
        public bool Status { get; set; }

        [BsonElement("createdAt")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime UpdatedAt { get; set; }

    }


    public class Comment
    {
        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("userName")]
        public string UserName { get; set; }

        [BsonElement("userAvatar")]
        public string UserAvatar { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("cmtDate")]
        public DateTime CmtDate { get; set; }

        [BsonElement("_id")]
        public ObjectId CommentId { get; set; }
    }
}
