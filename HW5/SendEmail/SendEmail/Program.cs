using System;
using System.Net.Mail;

namespace SendEmail
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("SEND TO ADDRESS: ");
			var toAddress = Console.ReadLine();
			Console.Write("SUBJECT: ");
			var subject = Console.ReadLine();
			Console.Write("BODY: ");
			var body = Console.ReadLine();
			Console.WriteLine("Sending..");
			SendMessage(toAddress, subject, body);
		}

		public static void SendMessage(string toAddress, string subject, string body)
		{
			var message = new MailMessage("collin.heretick@rockets.utoledo.edu", toAddress)
			{
				Subject = subject, Body = body
			};

			var client = new SmtpClient("outlook.office365.com")
			{
				Port = 587,
				Credentials = new System.Net.NetworkCredential("chereti2@rockets.utoledo.edu", "Floyd91-"),
				EnableSsl = true
			};

			try
			{
				client.Send(message);
				Console.WriteLine("Message sent!");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception caught in SendMessage(): {0}", ex.ToString());
			}
		}
	}
}
