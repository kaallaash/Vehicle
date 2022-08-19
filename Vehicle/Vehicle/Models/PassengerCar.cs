using Vehicle.Contracts;

namespace Vehicle.Models;
public class PassengerCar : IVehicle
{
    public PassengerCar(
        int maxSpeed,
        int maxTankCapacity,
        double averageFuelConsumption,
        int passangerCount = 1,
        int speed = -1,
        int tankCapacity = -1
        )
    {
        MaxSpeed = maxSpeed;
        MaxTankCapacity = maxTankCapacity;
        AverageFuelConsumption = averageFuelConsumption;
        PassangerCount = passangerCount <= 6 ? passangerCount : 5;
        Speed = speed == -1 ? maxSpeed / 2 : speed;
        TankCapacity = tankCapacity == -1 ? maxTankCapacity / 2 : tankCapacity;
    }
    public double AverageFuelConsumption { get; set; }
    public int MaxSpeed { get; }
    public int MaxTankCapacity { get; }
    public int PassangerCount { get; set; }
    public int Speed { get; set; }
    public int TankCapacity { get; set; }
    public int GetMaxWay()
    {
        var coef = 1 - PassangerCount * 0.06;
        var maxWay = MaxTankCapacity / AverageFuelConsumption * 100 * coef;
        return (int)Math.Ceiling(maxWay);
    }
    public int GetWay()
    {
        var coef = 1 - PassangerCount * 0.06;
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
