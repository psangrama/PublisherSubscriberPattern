## Publisher Subscriber Design Pattern
### Publisher Subscriber Design Pattern using event delegate

Publish-Subscribe or Pub-Sub is a flexible design pattern which allows disparate system components to interact with one another asynchronously and allows loose coupling of application components. This architecture can otherwise called as event-driven architecture as well. This usually comprise of three core components.

 **Publisher :** An object which publish the event.
 
 **Subscriber :** An object that subscribes, can accept/listens this event published by Publisher.
 
 **Events :** These are the notifications raised by the publisher.

### Advantages:
1. Loose couplings
2. Scalability
3. Separation of concern
4. Cleaner Design
5. Flexibility
6. Improved Testability
7. Improved Security

### Disadvantages:
1. Delivery status - publishers have no knowledge of the status about the subscriber and vice versa.
2. Subscribers and publishers increases would cause instabilities in the architecture.

# Best cases of using this pattern?

*Use this pattern when:*

1. An application needs to broadcast information to a significant number of consumers.
2. An application needs to communicate with one or more independently-developed applications or services, which may use different platforms, programming languages, and communication protocols.
3. An application can send information to consumers without requiring real-time responses from the consumers.
4. The systems being integrated are designed to support an eventual consistency model for their data.
5. An application needs to communicate information to multiple consumers, which may have different availability requirements or uptime schedules than the sender.

*This pattern might not be useful when:*

1. An application has only a few consumers who need significantly different information from the producing application.
2. An application requires near real-time interaction with consumers.

### Overall Architecture
