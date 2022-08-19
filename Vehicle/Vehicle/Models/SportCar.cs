using Vehicle.Contracts;

namespace Vehicle.Models;

public class SportCar : IVehicle
{
    public SportCar(
        int maxSpeed,
        int maxTankCapacity,
        double averageFuelConsumption,
        int speed = -1,
        int tankCapacity = -1
        )
    {
        MaxSpeed = maxSpeed;
        MaxTankCapacity = maxTankCapacity;
        AverageFuelConsumption = averageFuelConsumption;
        Speed = speed == -1 ? maxSpeed / 2 : speed;
        TankCapacity = tankCapacity == -1 ? maxTankCapacity / 2 : tankCapacity;
    }
    public double AverageFuelConsumption { get; set; }
    public int MaxTankCapacity { get; }
    public int MaxSpeed { get; }
    public int TankCapacity { get; set; }
    public int Speed { get; set; }
    public int GetMaxWay()
    {
        return (int)Math.Ceiling(MaxTankCapacity / AverageFuelConsumption * 100);
    }
    public int GetWay()
    {
        return (int)Math.Ceiling(TankCapacity / AverageFuelConsumption * 100);
    }
    public int GetTime(int wayLength)
    {
        double hours = wayLength / Speed;
        var minutes = (int)Math.Floor(hours * 60);
        return minutes;
    }
}
