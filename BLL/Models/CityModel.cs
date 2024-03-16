using DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BLL.Models;

public class CityModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(64)]
    public string CityName { get; set; } = null!;

    public int CityPopulation { get; set; }

    [Required]
    public string SityType { get; set; }

    public Country Country { get; set; }
}
