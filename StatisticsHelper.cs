public class StatisticsHelper 
{ 
    public static double CalculateAverage(int[] numbers) 
    {
	int suma = 0;
	foreach(var n in numbers)
	{
		suma +=n;
	}
	return (double)suma/numbers.Length;
	}
	
}