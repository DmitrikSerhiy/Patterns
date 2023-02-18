using Decorator;

Console.Title = "Decorator";

IMailSender desktopMailSender = new DesktopMailSender();
IMailSender webMailSender = new WebMailSender();
// basic use
webMailSender.SendMail();
desktopMailSender.SendMail();


// use with added (decorated) functionality
var statisticDecorator1 = new StatisticsDecorator(desktopMailSender);
statisticDecorator1.SendMail();

var messageDecorator1 = new MessagesDecorator(desktopMailSender);
messageDecorator1.SendMail();


var statisticDecorator2 = new StatisticsDecorator(webMailSender);
statisticDecorator2.SendMail();

var messageDecorator2 = new MessagesDecorator(webMailSender);
messageDecorator2.SendMail();
