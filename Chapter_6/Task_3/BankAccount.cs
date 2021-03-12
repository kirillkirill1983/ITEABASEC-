using System;


namespace Task_3
{
    class BankAccount
    {
        private DateTime dateopen;
        private double interestRate;
        private int invoiceAmount;

        public DateTime DateOpen 
        {
            set { dateopen = value; }
            get { return dateopen; }
        }
        public double InterestRate 
        {
            set { interestRate = value; }
            get { return interestRate; }
        }
        public int InvoiceAmount 
        {
            set { invoiceAmount = value; }
            get { return invoiceAmount; }
        }

        public BankAccount(DateTime datenter,double interestRateEnter, int invoiceAmountEnter)
        {
            dateopen = datenter;
            interestRate = interestRateEnter/100;
            invoiceAmount = invoiceAmountEnter;
        }
       //количество дней на депозите 
        public void NumberOfDays(DateTime dateTime)
        {
            TimeSpan dateTime1;
            dateTime1= dateopen.Subtract(dateTime);
            //Console.WriteLine($"{dateTime1.ToString("%d")} <===>  дней депозита ");
            int day = Convert.ToInt32(dateTime1.ToString("%d"));
            Console.WriteLine($"Общее количество дней депозита {day}");
        }
        //Сумма после депозита
        public void DepositAmount(int year)
        {
            //double deposuteAmoint = year *((interestRate * invoiceAmount * 365) / 100);
            double deposuteAmoint = year*(invoiceAmount*interestRate) ;
            Console.WriteLine(String.Format("Сумма по депозиту =>> {0:f}",deposuteAmoint));
        }

        public void SummaNow() 
        {
            Console.WriteLine($"Сумма на счете {invoiceAmount}");
        }
    }
}
