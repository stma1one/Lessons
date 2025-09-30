namespace Lesson02_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("enter account number");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("enter initial  amount");
                int amount = int.Parse(Console.ReadLine());
				BankAccount account = new BankAccount(accountNumber, amount);
                OperationResult res = account.WithDraw(1500);
                if (!res.Success)
					Console.WriteLine(  res.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Input was not in a correct format. " + ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An error occurred while creating the account: " + ex.Message);
			}

			catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
          
		}
    }
}
