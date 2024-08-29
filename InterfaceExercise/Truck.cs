using System;

namespace InterfaceExercise;

public class Truck : CarList, IVehicle, ICompany
{
    #region Properties

    public int BedLengthIn { get; set; }

    public int TruckHeightFt { get; set; }

    public int NumberOfWheels { get; set; }

    public string EngineNoise { get; set; }

    public int WindowTint { get; set; }

    public string PaintJob { get; set; }

    public string LogoDescription { get; set; }

    public bool UsesChildLabor { get; set; }

    #endregion

}