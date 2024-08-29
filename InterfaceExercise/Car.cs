using System;

namespace InterfaceExercise;

public class Car : CarList, ICompany, IVehicle
{
    #region Properties
    public bool HasTrunk { get; set; }
    public bool IsConvertable { get; set; }
    public string LogoDescription { get; set; }
    public bool UsesChildLabor { get; set; }
    public int NumberOfWheels { get; set; }
    public string EngineNoise { get; set; }
    public int WindowTint { get; set; }
    public string PaintJob { get; set; }
    #endregion
}