using Strategy;

Console.Title = "Strategy";

IExportService jsonExport = new ExportJsonService();
IExportService xmlExport = new ExportXmlService();


var order = new Order
{
    Details = "some details",
    Price = 100,
    ExportService = jsonExport
};

order.Export();
order.ExportService = xmlExport;
order.Export();

Console.ReadLine();