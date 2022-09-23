using System;

namespace PublisherSubscriberPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Main Thread Id - {System.Threading.Thread.CurrentThread.ManagedThreadId}");

			// Setup
			Publisher publisher = new Publisher();
			EvenOddValidatorSubscriber displayifEvenorOdd = new EvenOddValidatorSubscriber();
			PrimeValidatorSubscriber displayifPrime = new PrimeValidatorSubscriber();

			// Subscribed to events
			publisher.Subscribe(displayifEvenorOdd.ValidationMessageDisplay);
			publisher.Subscribe(displayifPrime.ValidationMessageDisplay);

			// Initiation
			publisher.InitiateSequence();

			// Unsubscribed to the events
			Console.WriteLine("Unsubscribed!");
			publisher.Unsubscribe(displayifEvenorOdd.ValidationMessageDisplay);
			
			publisher.InitiateSequence();
		}
	}
}