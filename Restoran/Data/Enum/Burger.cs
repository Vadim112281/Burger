using System.ComponentModel.DataAnnotations;

namespace Restoran.Data.Enum;

public enum Burger
{
    [Display(Name="Міні")]
    Mini = 1,
    [Display(Name="Середній")]
    Middle = 2,
    [Display(Name="Великий")]
    Max = 3
}