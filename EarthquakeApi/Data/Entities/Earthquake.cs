using System;
using EarthquakeApi.Data.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EarthquakeApi.Data.Entities;

public class Earthquake
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    public Source Source { get; set; }
    
    public DateTime Date { get; set; }

    public string SourceReferenceId { get; set; }

    public string Location { get; set; }

    public double Latitude { get; set; }
    
    public double Longitude { get; set; }

    public double Depth { get; set; }
    
    public double Magnitude { get; set; }

    public string Address { get; set; }

    public DateTime CreatedAt { get; set; }
    
    public string CreatedBy { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public string UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }
}