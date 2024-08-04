using OrderApi.Common.Enums;

namespace OrderApi.Data.Entities;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime CreateTime { get; set; }
    public OrderStatusType Status { get; set; }
    public string? FailMessage { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; } = [];
}