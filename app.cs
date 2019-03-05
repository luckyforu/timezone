sing System;
					
public class Program
{
	public static void Main()
	{
		DateTime dayLightSavings_Off = new DateTime(2019, 03, 02, 17, 00, 00); // 2nd March 2019, 5 PM, Daylights are off
		DateTime dayLightSavings_On = new DateTime(2019, 03, 15, 17, 00, 00); // 15the March 2019, 5 PM, Daylights are on
		// string easternZoneId = "Eastern Standard Time"; // This is Windows StandardName
		string easternZoneId = "America/New_York"; // This is IANA Standard Name

		try
		{
			TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(easternZoneId);
			Console.WriteLine("The date and time are {0} UTC.", TimeZoneInfo.ConvertTimeToUtc(dayLightSavings_Off, easternZone));
			Console.WriteLine("The date and time are {0} UTC.", TimeZoneInfo.ConvertTimeToUtc(dayLightSavings_On, easternZone));
		}
		catch (TimeZoneNotFoundException)
		{
			Console.WriteLine("Unable to find the {0} zone in the registry.", easternZoneId);
		}                           
		catch (InvalidTimeZoneException)
		{
			Console.WriteLine("Registry data on the {0} zone has been corrupted.", easternZoneId);
		}
	}
}
