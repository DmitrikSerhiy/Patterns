using TemplateMethod;

Console.Title = "Template Method";

MailProvider gmail = new GmailProvider();
MailProvider outlook = new OutlookProvider();

gmail.ExecuteMail();

outlook.ExecuteMail();

Console.ReadLine();