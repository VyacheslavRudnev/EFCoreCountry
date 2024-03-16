using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public class Country
{
    public int Id { get; set; }

    [Required]
    [StringLength(64)]
    public string CountryName { get; set; }

    public ICollection<City> City { get; set; }

    public override string ToString()
    {
        return $"{Id}| {CountryName}";
    }
}
