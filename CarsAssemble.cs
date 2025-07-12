static class AssemblyLine
{
    private const int numCars = 221;
    
    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return 1.00;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.90;
        }
        else if (speed == 9)
        {
            return .80;
        }
        else if (speed >= 10)
        {
            return 0.77;
        }
        else
        {
            return 0.00;
        }
    }
    
    public static double ProductionRatePerHour(int speed) => numCars * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
   
}
