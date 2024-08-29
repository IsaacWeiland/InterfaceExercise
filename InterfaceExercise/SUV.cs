using System;

namespace InterfaceExercise;

public class SUV : CarList, IVehicle, ICompany
{
    #region Properties

    public bool HasTopRack { get; set; }

    public bool CanOffRoad { get; set; }

    public int NumberOfWheels { get; set; }

    public string EngineNoise { get; set; }

    public int WindowTint { get; set; }

    public string PaintJob { get; set; }

    public string LogoDescription { get; set; }

    public bool UsesChildLabor { get; set; }

    #endregion
}