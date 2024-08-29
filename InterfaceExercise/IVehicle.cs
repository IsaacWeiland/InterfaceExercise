namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfWheels { get; set; }
    public string EngineNoise { get; set; }
    public int WindowTint { get; set; }
    public string PaintJob { get; set; }
}