namespace Entities;

public class Product {

    [BsonId]
    // [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("title")]
    public string Title { get; set; }

    [BsonElement("unitprice")]
    public decimal UnitPrice { get; set; }
}

