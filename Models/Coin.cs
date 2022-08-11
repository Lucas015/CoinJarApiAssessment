public class Coin
{

    public readonly eCoinType CoinType;

    public Coin(eCoinType coinType)
    {
        CoinType = coinType;
    }

    public decimal Amount { get; set; } = 0;
    public double Volumne { get; set; } = 0;

}