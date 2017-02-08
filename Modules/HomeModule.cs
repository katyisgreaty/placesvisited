using Nancy;
using Places.Objects;
using System;
using System.Collections.Generic;

namespace Places
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/view_all_places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["view_all_places.cshtml", allPlaces];
      };

      Get["/places/new"] = _ => {
       return View["place_form.cshtml"];
     };

     Get["/places/{id}"] = parameters => {
       Place place = Place.Find(parameters.id);
       return View["place.cshtml", place];
     };

      Post["/view_all_places"] = _ => {
        Place newPlace = new Place(Request.Form["new-city"], Request.Form["new-date"]);
        List<Place> allPlaces = Place.GetAll();
        return View["view_all_places.cshtml", allPlaces];
      };

      Post["/places_cleared"] = _ => {
        Place.ClearAll();
        return View["places_cleared.cshtml"];
      };
    }
  }
}
