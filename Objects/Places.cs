using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;
    private int _date;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city, int date)
    {
      _city = city;
      _date = date;
      _instances.Add(this);
      _id = _instances.Count;
    }

// instances
    public string GetCity()
    {
      return _city;
    }
    public void SetCity (string newCity)
    {
      _city = newCity;
    }
// date
    public int GetDate()
    {
      return _date;
    }
    public void SetDate (int newDate)
    {
      _date = newDate;
    }

    public int GetId()
    {
      return _id;
    }

// instances
    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
