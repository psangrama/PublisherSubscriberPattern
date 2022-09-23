using System;
using System.Threading;
using System.Threading.Tasks;

namespace PublisherSubscriberPattern
{
	class PrimeValidatorSubscriber:ISubscriber
	{
		public async void ValidationMessageDisplay(string randomNumber)
		{
			await Task.Run(() =>
			{
				var _rNumber = Convert.ToInt32(randomNumber?.Split('-')[1]);

				string message = string.Empty;
				if (IsPrime(_rNumber))
				{
					message = $"Sub - PrimeNumValidator (delayed - 5 sec): {_rNumber} is a prime number. Completed at {DateTime.Now} using thread {Thread.CurrentThread.ManagedThreadId}";
				}
				else
				{
					message = $"Sub - PrimeNumValidator (delayed - 5 sec): {_rNumber} is not a prime number. Completed at {DateTime.Now} using thread {Thread.CurrentThread.ManagedThreadId}";
				}
				Console.WriteLine(message);
				Thread.Sleep(5000);
			});
		}

		private bool IsPrime(int number)
		{
			if (number <= 3 && number > 1)
				return true;            // as 2 and 3 are prime
			else if (number == 1 || number % 2 == 0 || number % 3 == 0)
				return false;     // check if number is divisible by 2 or 3
			else
			{
				int i;
				for (i = 5; i * i <= number; i += 6)
				{
					if (number % i == 0 || number % (i + 2) == 0)
						return false;
				}
				return true;
			}
		}
	}
}
