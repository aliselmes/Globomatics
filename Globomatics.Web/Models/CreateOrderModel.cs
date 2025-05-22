namespace Globomatics.Web.Models;

public class CreateOrderModel
{
    public Guid? CartId { get; set; }
    public CustomerModel Customer { get; init; }
}