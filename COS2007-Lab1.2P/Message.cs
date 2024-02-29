using System;
namespace COS2007_Lab1._2P
{
	public class Message
	{
		private string _text;

		public Message(string text)
		{
			_text = text;
		}

		public void Print()
		{
			Console.WriteLine(_text);
			Console.ReadKey();
		}
	}
}

