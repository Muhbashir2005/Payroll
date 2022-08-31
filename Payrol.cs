namespace CodeChallenge
{
    public class Payrol
    {
        public static string PayRoll(int numOfHours)
        {
            string result = "";
            decimal monthGross = 0;
            decimal monthNet = 0;
            decimal weekEarn = 0;
            decimal overTime = 0;
            decimal overTimePay = 0;
            decimal total = 0;
            decimal tax = 0;
            decimal percent = 0;
            
            if (numOfHours > 8 )
            {
                overTime = numOfHours - 8;
                monthGross = 8 * 5 * 4 * 25;
                overTimePay = (overTime * 10) * 4 * 5;
                total = monthGross + overTimePay;
                weekEarn = total/4;
            }
            else
            {
                monthGross = numOfHours* 5*4*25;
                total = monthGross;
                weekEarn = monthGross/4;
            }
            if (monthGross <= 1000)
            {
                percent = 0.015m;
                tax = percent * monthGross;
                monthGross += tax;
                monthNet = monthGross - tax;
            }
            else if(monthGross > 1000 && monthGross <= 2500)
            {
               percent = 0.025m;
               tax = percent * monthGross;
               monthGross += tax;
               monthNet = monthGross - tax;
            }
            else if(monthGross > 2500)
            {
                percent = 0.045m;
                tax = percent * monthGross;
                monthGross += tax;
                monthNet = monthGross - tax;
            }
            
            result = $"Month Gross = ${total }\nTax = {tax}\nNet Earning = ${monthNet + overTimePay - tax}\nWeekly Pay = ${weekEarn}\nTotal Over-Time = ${overTimePay}";
            return result;
        } 
    }
}