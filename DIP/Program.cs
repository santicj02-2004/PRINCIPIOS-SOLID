
using DIP;

IMessageSender emailSender = new EmailSender();
NotificationService emailNotification = new NotificationService(emailSender);
emailNotification.Notify("Your order has been shipped!");

   
IMessageSender smsSender = new SmsSender();
NotificationService smsNotification = new NotificationService(smsSender);
smsNotification.Notify("Your order has been shipped!");
    
