public class CoinJar
{
    public CoinJar()
    {
        
    }
    private readonly Coin[] coins = Enum.GetValues(typeof(eCoinType)).Cast<eCoinType>().Select(x => new Coin(x)).ToArray(); 

    public decimal GetTotalAmount() => coins.select(c => (decimal))

    public void Reset()
    {
        foreach (var coin in coins)
        {
            coin.Amount = 0;
        }
    }
    
}