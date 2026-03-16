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
public statis int CalculateMax(int[] numbers)
{
	int max = numbers[0];
	foreach(var n in numbers){
	if (max < n) max = n;		
}
	return max;
}
public static int CalculateMin(int[] numbers)
{
	in min = numbers[0];
	foreach(var n in numbers){
	if min > n) min = n;		
}
	return min;
}
}
	
}