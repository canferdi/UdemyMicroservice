using MongoDB.Bson.Serialization.Attributes;

namespace UdemyMicroservice.Catalog.Api.Repositories;

public abstract class BaseEntity
{
    // snowflake id generator
    [BsonElement("_id")] 
    public Guid Id { get; set; }
}