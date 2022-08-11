using System;
using System.Linq;
using CoinJarApiAssessment.Interface;

namespace CoinJarApiAssessment.Repository
{
    public class CoinJarRepository : ICoinJar
    {
        public CoinJarRepository()
        {

        }

        private readonly Coin[] coins = Enum.GetValues(typeof(eCoinType)).Cast<eCoinType>().Select(x => new Coin(x)).ToArray();

        public void AddCoin(eCoinType coinType, int count = 1)
        {
            double MaxVolumne = 1242088.24;
            double CoinVolumn = CalculateVolumne(coinType);

            if ((coins.Select(c => (double)c.Volumne).Sum() + CoinVolumn) > MaxVolumne)
            {
                throw new ArgumentException("The coin does not fit in the jar");
            }
            else
            {
                coins.First(t => t.CoinType == coinType).Amount += count;
                coins.First(t => t.CoinType == coinType).Volumne += CoinVolumn;

            }

        }

        public decimal GetTotalAmount() => coins.Select(c => (decimal)c.CoinType * c.Amount).Sum();

        public void Reset()
        {
            foreach (var coin in coins)
            {
                coin.Amount = 0;
                coin.Volumne = 0;
            }
        }

        private double CalculateVolumne(eCoinType coinType)
        {

            double heightInMm = 0;
            double radiusInMM = 0;

            switch (coinType)
            {
                case (eCoinType)1:
                     heightInMm = 1.55;
                     radiusInMM = 9.525;
                    break;
                case (eCoinType)5:
                     heightInMm = 1.95;
                     radiusInMM = 10.605;
                    break;
                    case (eCoinType)10:
                     heightInMm = 1.35;
                     radiusInMM = 8.955;
                    break;
                case (eCoinType)25:
                     heightInMm = 1.75;
                     radiusInMM = 12.13;
                    break;
                case (eCoinType)50:
                     heightInMm = 2.15;
                     radiusInMM = 15.305;
                    break;
                case (eCoinType)100:
                     heightInMm = 2;
                     radiusInMM = 13.245;
                    break;

                default:
                    break;
            }


            return (double)(Math.PI*Math.Pow(radiusInMM, 2)*heightInMm);
        }

    }
}
