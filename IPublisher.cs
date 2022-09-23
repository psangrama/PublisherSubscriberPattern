namespace PublisherSubscriberPattern
{
	public interface IPublisher
	{
		void Subscribe(RandomNumberDelegate nameHandler);
		void Unsubscribe(RandomNumberDelegate nameHandler);
	}
}
