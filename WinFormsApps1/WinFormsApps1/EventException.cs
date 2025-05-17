using System;

namespace EventException
{
	public class EmptyFieldException:Exception
	{
		public EmptyFieldException(string Message):base(Message)
		{
		}
	}
	public class PasswordMisMatchException: Exception
	{
		public PasswordMisMatchException(string Message) : base(Message)
        {
        }
    }

}
