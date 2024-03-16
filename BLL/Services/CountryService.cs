using BLL.Models;
using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services;

public class CountryService
{
    private DataContext _dataContext;

    public CountryService(string connectionString)
    {
        DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
            .UseSqlServer(connectionString)
            .Options;
        _dataContext = new DataContext(options);
        var entity = _dataContext.Country.Add(new Country()
        {
            CountryName = "Ukrain",
        });
        _dataContext.City.Add(new City()
        {
            CityName = "Kyiv",
            CityPopulation = 3000000,
            SityType = "Сapital city",
            Country = entity.Entity,
        });
        _dataContext.City.Add(new City()
        {
            CityName = "Lviv",
            CityPopulation = 950000,
            SityType = "Regional center",
            Country = entity.Entity,
        });
        _dataContext.City.Add(new City()
        {
            CityName = "Sumy",
            CityPopulation = 800000,
            SityType = "Regional center",
            Country = entity.Entity,
        });
        _dataContext.SaveChanges();
    }

    public List<CityModel> GetAll()
    {
        return _dataContext.City
            .Select(b => new CityModel()
        {
            Id = b.Id,
            CityName = b.CityName,
            CityPopulation = b.CityPopulation,
            SityType = b.SityType,
            Country = b.Country,
        }).ToList();
    }
}
