using DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace BLL.Models;

public class CountryModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(64)]
    public string CountryName { get; set; } = null!;

    public List<City> City { get; set; }
}
