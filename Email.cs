using System;
using System.Collections.Generic;

namespace Solid
{
	public class Email : IEmail
	{
		public void Send(List<Subscriber> subscribers, string message)
		{
			foreach(var subscriber in subscribers)
			{
				Send(subscriber, message);
			}
		}

		public void Send(Subscriber subscriber, string message)
		{
			subscriber.Notify(this, message);
		}	

		public void PrintNotification(string tagLine, string message)
		{
			Console.WriteLine(tagLine);
			Console.WriteLine($"Email: {message}");
			Console.WriteLine("");			
		}
	}
}