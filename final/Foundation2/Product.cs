public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    
    private int _quantity;
    
   
    public int GetFinalPrice()
    {
        int theFinalPrice = _price * _quantity;
        return theFinalPrice;
    }
}