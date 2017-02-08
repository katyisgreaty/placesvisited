using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;

    private static List<Place> _instances = new List<Place> {};

    public Place (string city)
    {
      _city = city;
    }

// city
    public string GetCity()
    {
      return _city;
    }
    public void SetCity (string newCity)
    {
      _city = newCity;
    }

// instances
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
