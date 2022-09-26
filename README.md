# PublisherSubscriberPattern
Publisher Subscriber Design Pattern using event delegate

Publish-Subscribe or Pub-Sub is a flexible design pattern which allows disparate system components to interact with one another asynchronously and allows loose coupling of application components. This architecture can otherwise called as event-driven architecture as well. This usually comprise of three core components.

Publisher : An object which publish the event.
Subscriber : An object that subscribes, can accept/listens this event published by Publisher.
Events : These are the notifications raised by the publisher.

[Diagram] - Problem and it's solution

[RealLife Example] - for better understanding

Advantages:

Loose couplings

Scalability

Separation of concern

Cleaner Design

Flexibility

Disadvantages:

Delivery status - publishers have no knowledge of the status about the subscriber and vice versa.

Subscribers and publishers increases would cause instabilities in the architecture.
