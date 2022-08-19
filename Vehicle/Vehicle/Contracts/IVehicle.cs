namespace Vehicle.Contracts;

public interface IVehicle
{
    public double AverageFuelConsumption { get; set; }
    public int MaxTankCapacity { get; }
    public int MaxSpeed { get; }
    public int TankCapacity { get; set; }
    public int Speed { get; set; }
    public int GetMaxWay();
    public int GetWay();
    public int GetTime(int wayLength);
}
