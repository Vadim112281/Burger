using System.ComponentModel.DataAnnotations;

namespace Restoran.Data.Enum;

public enum Meat
{   
    [Display(Name="Говядина")]
    Beef,
    [Display(Name="Cвинина")]
    Pork,
    [Display(Name="Курятина")]
    Chicken
}