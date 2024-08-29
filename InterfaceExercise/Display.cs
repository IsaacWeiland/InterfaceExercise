using System;
using System.Collections.Generic;
using System.Threading;

namespace InterfaceExercise;

public static class Display
{
    public static void Run()
    {
        #region Initializations

        var lambo = new Car()
        {
            HasTrunk = true,
            IsConvertable = false,
            LogoDescription = "Gold badge with a bull charging",
            UsesChildLabor = false,
            NumberOfWheels = 4,
            EngineNoise = "purrs",
            WindowTint = 35,
            PaintJob = "Aquamarine"
        };

        var ford = new Truck()
        {
            BedLengthIn = 77,
            TruckHeightFt = 10,
            NumberOfWheels = 6,
            EngineNoise = "Roar",
            WindowTint = 5,
            PaintJob = "straight up RGB lights all over the car",
            LogoDescription = "It's ford",
            UsesChildLabor = true
        };

        var kia = new SUV()
        {
            HasTopRack = true,
            CanOffRoad = true,
            NumberOfWheels = 4,
            EngineNoise = "Grumble",
            WindowTint = 75,
            PaintJob = "pure white",
            LogoDescription = "the letters K, I, and an upside down V",
            UsesChildLabor = true
        };

        #endregion

        #region CarDisplayTo

        string trunkStatus = "will not have a trunk";
        if (lambo.HasTrunk)
        {
            trunkStatus = "will have a trunk";
        }
        Console.WriteLine($"This new hypothetical model {trunkStatus}. They will be provided by default a tint of {lambo.WindowTint}.");
        Console.WriteLine($"It will have {lambo.NumberOfWheels} wheels, the engine will {lambo.EngineNoise}.");
        Console.WriteLine($"This particular model is {lambo.PaintJob}");
        if (lambo.IsConvertable)
        {
            Console.WriteLine("This model will be a convertable.");
        }
        else
        {
            Console.WriteLine("This model will not be a convertable.");
        }

        Console.WriteLine($"And finally, we will have our, beautiful logo displayed, a {lambo.LogoDescription}.");

        #endregion
        Console.WriteLine();
        Thread.Sleep(1000);
        #region TruckDisplayTo

        
        Console.WriteLine($"This new hypothetical model has {ford.BedLengthIn} inch bed length. " +
                          $"They will be provided by default a tint of {ford.WindowTint}.");
        Console.WriteLine($"It will have {ford.NumberOfWheels} wheels, the engine will {ford.EngineNoise}, and will be a height of {ford.TruckHeightFt} feet.");
        Console.WriteLine($"This particular model is {ford.PaintJob}");
        Console.WriteLine($"And finally, we will have our, beautiful logo displayed, a {ford.LogoDescription}.");

        #endregion
        Console.WriteLine();
        Thread.Sleep(1000);
        #region SUVDisplayTo

        string rackStatus = "will not have a top rack";
        if (kia.HasTopRack)
        {
            rackStatus = "will have a top rack";
        }
        Console.WriteLine($"This new hypothetical model {rackStatus}. They will be provided by default a tint of {kia.WindowTint}.");
        Console.WriteLine($"It will have {kia.NumberOfWheels} wheels, the engine will {kia.EngineNoise}.");
        Console.WriteLine($"This particular model is {kia.PaintJob}");
        if (kia.CanOffRoad)
        {
            Console.WriteLine("This model will be able to off road.");
        }
        else
        {
            Console.WriteLine("This model will not be able to off road.");
        }

        Console.WriteLine($"And finally, we will have our, beautiful logo displayed, a {kia.LogoDescription}.");

        #endregion
    }
}