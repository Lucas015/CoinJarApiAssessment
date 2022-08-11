namespace CoinJarApiAssessment.Interface
{
    public interface ICoinJar
    {
        void AddCoin(eCoinType coinType, int count = 1);
        decimal GetTotalAmount();
        void Reset();
    }
}
