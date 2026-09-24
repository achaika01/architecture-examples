namespace DIP.Orders.Before.Infrastructure;

public class SmtpEmailSender
{
    public void Send(string recipient, string subject, string body)
    {
        // Simulated SMTP: no network connection or credentials needed.
        Console.WriteLine($"[Email] To: {recipient} | {subject} | {body}");
    }
}
