using System;

namespace EventException
{
	public class EmptyFieldException:Exception
	{
		public EmptyFieldException(string Message):base(Message)
		{
		}
	}
}
