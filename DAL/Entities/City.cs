using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public class City
{
    public int Id { get; set; }

    [Required]
    [StringLength(64)]
    public string CityName { get; set; } = null!;

    public int CityPopulation { get; set; }

    public string? SityType { get; set; }

    public Country Country { get; set; }

}
