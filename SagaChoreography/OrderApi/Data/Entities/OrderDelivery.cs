namespace OrderApi.Data.Entities;

public class OrderDelivery
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int CityId { get; set; }
    public required string Address { get; set; }

    public Order? Order { get; set; }
}