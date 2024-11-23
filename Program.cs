using netcore.coupling;

// with the hellp of abstaction and decoupling I can choose both way to send notification
// Order order = new Order(new EmailSender());
Order order = new Order(new SmsSender());
order.PlaceOrder();
