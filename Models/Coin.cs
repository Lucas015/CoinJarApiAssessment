public class Coin
{
    public readonly eCoinType CoinType;  
    public decimal Amount { get; set; } = 0;  
  
    public Coin(eCoinType coinType)  
    {  
        CoinType = coinType;  
    } 
}