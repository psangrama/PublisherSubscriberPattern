using System;
using System.Threading.Tasks;

namespace PublisherSubscriberPattern
{
	class EvenOddValidatorSubscriber : ISubscriber
	{	
		public async void ValidationMessageDisplay(string randomNumber)
		{
			await Task.Run(() =>
			{
				var _rNumber = Convert.ToInt32(randomNumber?.Split('-')[1]);
				string message = string.Empty;

				if (_rNumber % 2 != 0)
				{
					message = $"Sub - EvenOddValidator : {_rNumber} is an even number. Validated at {DateTime.Now}";
				}
				else
				{
					message = $"Sub - EvenOddValidator : {_rNumber} is a odd number. Validated at {DateTime.Now}";
				}
				Console.WriteLine(message);
			});
		}
	}
}
