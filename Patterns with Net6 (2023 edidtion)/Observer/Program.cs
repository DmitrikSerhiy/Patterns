using Observer;

Console.Title = "Observer";

var office = new OfficeTicketService();
var stock = new StockTicketService();

OrderTicketService orderTicketService = new OrderTicketService();

orderTicketService.AddObserver(office); // subscribe
orderTicketService.AddObserver(stock);

orderTicketService.CompleteTicketSale(10);

orderTicketService.RemoveObserver(stock); // unsubscibe
orderTicketService.CompleteTicketSale(20);


Console.ReadKey();