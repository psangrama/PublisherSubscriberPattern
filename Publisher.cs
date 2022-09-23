using System;
using System.Threading;

namespace PublisherSubscriberPattern
{
	public class Publisher : IPublisher
	{
		private event RandomNumberDelegate _randomNumber;
		public async void Subscribe(RandomNumberDelegate randomNumberHandler)
		{
			_randomNumber += randomNumberHandler;
		}
		public void Unsubscribe(RandomNumberDelegate randomNumberHandler)
		{
			_randomNumber -= randomNumberHandler;
		}

		public async void InitiateSequence()
		{	
			int runCount = 0;
			while (runCount < 10)
			{
				string tempString = $"Sl# {runCount} : Number - {GenerateRandomNumber()}";
				_randomNumber(tempString);
				Console.WriteLine($"Message published {tempString} at {DateTime.Now}.");
				Thread.Sleep(1000);
				runCount++;
			}
		}

		public static int GenerateRandomNumber()
		{
			Random r = new Random();
			return r.Next();
		}
	}
}
