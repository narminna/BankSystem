using System;
namespace Console_App6
{
    abstract class BankCard
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public decimal Balance { get; set; }
        public string TransferMethod { get; set; }
        public string WithdrawalMethod { get; set; }

        public abstract decimal CalculateWithdrawalFee(decimal withdrawalAmount);
        public abstract decimal CalculateDepositFee(decimal depositAmount);

        public override string ToString()
        {
            return $"CardHolderName: {CardHolderName}, CardNumber: {CardNumber}, CVV: {CVV}, Balance: {Balance}, TransferMethod: {TransferMethod}, WithdrawalMethod: {WithdrawalMethod}";
        }
    }

    class UnibankCard : BankCard
    {
        public UnibankCard(string cardHolderName, string cardNumber, string cvv, decimal balance, string transferMethod, string withdrawalMethod)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            CVV = cvv;
            Balance = balance;
            TransferMethod = transferMethod;
            WithdrawalMethod = withdrawalMethod;
        }

        public override decimal CalculateWithdrawalFee(decimal withdrawalAmount)
        {
            return withdrawalAmount * 0.015m;
        }

        public override decimal CalculateDepositFee(decimal depositAmount)
        {
            return 0;
        }
    }

    class AccessBankCard : BankCard
    {
        public AccessBankCard(string cardHolderName, string cardNumber, string cvv, decimal balance, string transferMethod, string withdrawalMethod)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            CVV = cvv;
            Balance = balance;
            TransferMethod = transferMethod;
            WithdrawalMethod = withdrawalMethod;
        }

        public override decimal CalculateWithdrawalFee(decimal withdrawalAmount)
        {
            return withdrawalAmount * 0.016m;
        }

        public override decimal CalculateDepositFee(decimal depositAmount)
        {
            return depositAmount * 0.003m;
        }

        class PashaBankCard : BankCard
        {
            public PashaBankCard(string cardHolderName, string cardNumber, string cvv, decimal balance, string transferMethod, string withdrawalMethod)
            {
                CardHolderName = cardHolderName;
                CardNumber = cardNumber;
                CVV = cvv;
                Balance = balance;
                TransferMethod = transferMethod;
                WithdrawalMethod = withdrawalMethod;
            }

            public override decimal CalculateWithdrawalFee(decimal withdrawalAmount)
            {
                return withdrawalAmount * 0.011m;
            }

            public override decimal CalculateDepositFee(decimal depositAmount)
            {
                return depositAmount * 0.006m;
            }
        }

        class LeoBankCard : BankCard
        {
            public LeoBankCard(string cardHolderName, string cardNumber, string cvv, decimal balance, string transferMethod, string withdrawalMethod)
            {
                CardHolderName = cardHolderName;
                CardNumber = cardNumber;
                CVV = cvv;
                Balance = balance;
                TransferMethod = transferMethod;
                WithdrawalMethod = withdrawalMethod;
            }

            public override decimal CalculateWithdrawalFee(decimal withdrawalAmount)
            {
                return 0;
            }

            public override decimal CalculateDepositFee(decimal depositAmount)
            {
                return 0;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                UnibankCard unibankCard = new UnibankCard("John Smith", "1234567890123456", "123", 600, "Method 1", "Method 2");
                AccessBankCard accessBankCard = new AccessBankCard("Alice Johnson", "9876543210987654", "456", 1500, "Method 3", "Method 4");
                PashaBankCard pashaBankCard = new PashaBankCard("Bob Williams", "4561237896541230", "789", 3470, "Method 5", "Method 6");
                LeoBankCard leoBankCard = new LeoBankCard("Charlie Davis", "9876543210123456", "321", 2736, "Method 7", "Method 8");

                Console.WriteLine(unibankCard.ToString());
                Console.WriteLine($"Withdrawal Fee: {unibankCard.CalculateWithdrawalFee(500)}");
                Console.WriteLine($"Deposit Fee: {unibankCard.CalculateDepositFee(1000)}");

                Console.WriteLine(accessBankCard.ToString());
                Console.WriteLine($"Withdrawal Fee: {accessBankCard.CalculateWithdrawalFee(500)}");
                Console.WriteLine($"Deposit Fee: {accessBankCard.CalculateDepositFee(1000)}");

                Console.WriteLine(pashaBankCard.ToString());
                Console.WriteLine($"Withdrawal Fee: {pashaBankCard.CalculateWithdrawalFee(500)}");
                Console.WriteLine($"Deposit Fee: {pashaBankCard.CalculateDepositFee(1000)}");

                Console.WriteLine(leoBankCard.ToString());
                Console.WriteLine($"Withdrawal Fee: {leoBankCard.CalculateWithdrawalFee(500)}");
                Console.WriteLine($"Deposit Fee: {leoBankCard.CalculateDepositFee(1000)}");
            }
        }
    }
}
