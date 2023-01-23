using System;
namespace praticaProjeto
{
	public class helperClass
	{
		public Boolean helperClass()
		{
			DateTime currentTime = DateTime.Now;
			if ((currentTime.DayOfWeek).ToString() == "Sunday")
			{
				return false;
			}
			else if ((currentTime.DayOfWeek).ToString() == "Saturday") {
				if (currentTime.Hour < 9 && currentTime.Hour >14)
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

