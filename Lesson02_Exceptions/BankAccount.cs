namespace Lesson02_Exceptions
{
	internal class BankAccount
	{
		public int AccountId { get; init; }
		public int Balance { get; private set;	}

		public BankAccount(int accountId, int initalBalance)
		{
			if(accountId<=0)
				throw new ArgumentException("Account ID must be positive");
			this.AccountId = accountId;
			if(initalBalance<0)
			{
				throw new ArgumentOutOfRangeException("Initial balance cannot be negative");
			}
			this.Balance= initalBalance;
		}

		public void Deposit(int amount)
		{
		
			
			this.Balance += amount;
		}

		public OperationResult WithDraw(int amount)
		{
			if(amount<0)
							{
				throw new ArgumentOutOfRangeException("Withdraw amount cannot be negative");
			}
			if (Balance<amount)
							{
				return  OperationResult.Failure("Insufficient funds", Balance);
			}
			if(Balance<10)
				return OperationResult.Failure("Balance too low to withdraw", Balance);
			else
			{
				this.Balance-= amount;
				return OperationResult.OK(Balance);
			}
		
		}
	}
}