using System;
using System.Net.Mail;

namespace SendEmail
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("SEND TO ADDRESS: ");
			string toAddress = Console.ReadLine();
			Console.WriteLine("SUBJECT: ");
			string subject = Console.ReadLine();
			Console.WriteLine("BODY: ");
			string body = Console.ReadLine();
			Console.WriteLine("Sending..");
			SendMessage("outlook.office365.com", toAddress, subject, body);
		}

		public static void SendMessage(string server,string toAddress, string subject, string body)
		{
			MailMessage message = new MailMessage("collin.heretick@rockets.utoledo.edu", toAddress)
			{
				Subject = subject, Body = body
			};

			SmtpClient client = new SmtpClient(server)
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
