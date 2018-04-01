namespace MyShop.Core.ViewModels
{
  public class BasketItemViewModel
  {
    // We are gonna inner join: product and basketItem model into this structure..
    // we need etc the price * quantity = sum AND productname => display for the user

    public string Id { get; set; }
    public int Quantity { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
  }
}
