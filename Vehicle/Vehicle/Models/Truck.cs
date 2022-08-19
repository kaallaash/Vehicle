using Vehicle.Contracts;

namespace Vehicle.Models;

public class Truck : IVehicle
{
    public Truck(
        int maxSpeed,
        int maxTankCapacity,
        double averageFuelConsumption,
        int cargo,
        int speed = -1,
        int tankCapacity = -1
        )
    {
        MaxSpeed = maxSpeed;
        MaxTankCapacity = maxTankCapacity;
        AverageFuelConsumption = averageFuelConsumption;
        Cargo = cargo;
        Speed = speed == -1 ? maxSpeed / 2 : speed;
        TankCapacity = tankCapacity == -1 ? maxTankCapacity / 2 : tankCapacity;
    }
    public double AverageFuelConsumption { get; set; }
    public int MaxTankCapacity { get; }
    public int MaxSpeed { get; }
    public int Cargo { get; set; }
    public int TankCapacity { get; set; }
    public int Speed { get; set; }
    public int GetMaxWay()
    {
        var coef = 1 - Cargo / 200 * 0.04;
        var maxWay = MaxTankCapacity / AverageFuelConsumption * 100 * coef;
        return (int)Math.Ceiling(maxWay);
    }
    public int GetWay()
    {
        var coef = 1 - Cargo / 200 * 0.04;
        var way = TankCapacity / AverageFuelConsumption * 100 * coef;
        return (int)Math.Ceiling(way);
    }
    public int GetTime(int wayLength)
    {
        double hours = wayLength / Speed;
        var minutes = (int)Math.Floor(hours * 60);
        return minutes;
    }
}
