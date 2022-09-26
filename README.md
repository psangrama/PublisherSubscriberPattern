# PublisherSubscriberPattern
*Publisher Subscriber Design Pattern using event delegate*

Publish-Subscribe or Pub-Sub is a flexible design pattern which allows disparate system components to interact with one another asynchronously and allows loose coupling of application components. This architecture can otherwise called as event-driven architecture as well. This usually comprise of three core components.

Publisher : An object which publish the event.
Subscriber : An object that subscribes, can accept/listens this event published by Publisher.
Events : These are the notifications raised by the publisher.

[Diagram] - Problem and it's solution

**Advantages:**
1. Loose couplings
2. Scalability
3. Separation of concern
4. Cleaner Design
5. Flexibility

**Disadvantages:**
1. Delivery status - publishers have no knowledge of the status about the subscriber and vice versa.
2. Subscribers and publishers increases would cause instabilities in the architecture.

[RealLife Example] - for better understanding
