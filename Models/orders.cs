
namespace EG_Mart.Models
{
    internal class orders
    {
        public int oId { get; set; }
        public int quantity { get; set; }
        public int customerId { get; set; }
        public int productId { get; set; }
    }
}
public class orderDto
{
    public int orderId { get; set; }
    public int Qty { get; set; }
    public string OrderPlace { get; set; }
    public int Rate { get; set; }

    private double Total()
    {
        return Qty * Rate;
    }

}
