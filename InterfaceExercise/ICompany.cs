using System.ComponentModel;
using System.Dynamic;

namespace InterfaceExercise;

public interface ICompany
{
    public string LogoDescription { get; set; }
    public bool UsesChildLabor { get; set; } //im making a real statement with this one
}