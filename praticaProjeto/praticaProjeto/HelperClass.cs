	using System;
namespace praticaProjeto
{
	public class HelperClass
	{
		public Boolean timeIsValid()
		{
			DateTime currentTime = DateTime.Now;
			if ((currentTime.DayOfWeek).ToString() == "sunday")
			{
				return false;
			}
			else if ((currentTime.DayOfWeek).ToString() == "saturday")
			{
				if (currentTime.Hour > 9 && currentTime.Hour < 14)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				if (currentTime.Hour > 9 && currentTime.Hour < 20)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}