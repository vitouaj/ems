
namespace EventAPI.Models;

public class Venue : Entity
{
    public Venue(
        Guid id,
        string name,
        string? description,
        string street,
        string district,
        string city,
        string buildingNo,
        string googleMapUrl,
        Guid createdBy,
        Guid updatedBy
        ) : base(name, description, createdBy, updatedBy)
    {
        Id = id;
        Street = street;
        District = district;
        City = city;
        BuildingNo = buildingNo;
        GoogleMapUrl = googleMapUrl;
    }
    public override Guid Id { get; set; }
    public string Street { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string BuildingNo { get; set; }
    public string GoogleMapUrl { get; set; }
    public List<Event> Events { get; set; } = [];
}

