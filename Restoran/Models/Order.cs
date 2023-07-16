using System.ComponentModel.DataAnnotations;
using Restoran.Data.Enum;

namespace Restoran.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    public Burger Burger { get; set; }
    public Meat Meat { get; set; }
    public int? Price { get; set; }

    public string Description { get; set; }






}