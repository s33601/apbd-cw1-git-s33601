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
public statis int CalculateMax(int[] numbers0
{
	int max = numbers[0];
	foreach(var n in numbers){
	if (max < n) max = n;		
}
	return max;
}
	
}