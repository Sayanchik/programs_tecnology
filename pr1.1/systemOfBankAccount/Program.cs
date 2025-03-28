using System;

namespace systemOfBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new InterestEarningAccount("aswdsa", 1000);
            Console.WriteLine($"Account {account1.Number.Value} " + 
                $"was created for {account1.Owner} " +
                $"with {account1.Balance} initial balance. ");
            var account2 = new LineOfCreditAccount("asa", 2000);
            Console.WriteLine($"Account {account2.Number.Value} " +
                $"was created for {account2.Owner} " +
                $"with {account2.Balance} initial balance. ");

            try
            {
                account1.MakeWithdrawal(500000m, DateTime.Now, "asd");
                account2.MakeDeposite(-1000m, DateTime.Now, "asd");
            }

            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message, e.ParamName, e.ToString());
            }

            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }
            finally
            {
                Console.WriteLine("Выполняется в любом случае. неважно произошло исключение или нет");
            }
        }


    }
}
