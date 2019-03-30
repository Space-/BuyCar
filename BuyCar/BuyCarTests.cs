using System;
using NUnit.Framework;

namespace BuyCar
{
    public class BuyCarTest
    {
        [Test]
        public void OldCar_2000_NewCar_8000_savingPerMonth_1000_percentLossByMonth_one_dot_five_percent_return_month_6_balance_766()
        {
            var periodOfMonthsAndBalance = new int[] { 6, 766 };
            Assert.AreEqual(periodOfMonthsAndBalance, BuyCar.nbMonths(2000, 8000, 1000, 1.5));
        }
    }

    public class BuyCar
    {
        public static int[] nbMonths(float nowPriceOldCar, float nowPriceNewCar, int savingPerMonth, double percentLossByMonth)
        {
            var periodOfMonths = 0;
            var descPercentPerMonth = (float)percentLossByMonth / 100f;
            var increaseLossPercentEveryTwoMonth = 0.005f;
            var priceLossPercentMonthCycle = 2;
            var balance = nowPriceOldCar - nowPriceNewCar;

            while (balance < 0)
            {
                // at the end of this month
                nowPriceOldCar = nowPriceOldCar - nowPriceOldCar * descPercentPerMonth;
                nowPriceNewCar = nowPriceNewCar - nowPriceNewCar * descPercentPerMonth;

                descPercentPerMonth = periodOfMonths % priceLossPercentMonthCycle == 0
                    ? descPercentPerMonth += increaseLossPercentEveryTwoMonth
                    : descPercentPerMonth;

                periodOfMonths++;

                //                var totalAssets = nowPriceOldCar + savingPerMonth * periodOfMonths;
                //                balance = totalAssets - nowPriceNewCar;

                balance = nowPriceOldCar + savingPerMonth * periodOfMonths - nowPriceNewCar;
            }

            return new int[] { periodOfMonths, (int)Math.Round(balance) };
        }
    }
}