using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
  public interface IRestaurantData
  {
    IEnumerable<Restaurant> GetAll();
  }

  public class InMemoryRestaurantData : IRestaurantData
  {
    List<Restaurant> restaurants;

    public InMemoryRestaurantData()
    {
      restaurants = new List<Restaurant>()
      {
        new Restaurant { Id=1, Name = "Scott's Pizza", Location="Maryland", Cuisine=CuisineType.Italian},
        new Restaurant { Id = 2, Name = "Mc Donalds", Location = "São Paulo", Cuisine = CuisineType.Indian },
        new Restaurant { Id = 3, Name = "Burger King", Location = "Campinas", Cuisine = CuisineType.Brazilian }
      };
    }

    public IEnumerable<Restaurant> GetAll()
    {
      return from r in restaurants
             orderby r.Name
             select r;
    }
  }
}
