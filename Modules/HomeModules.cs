using Nancy;
using System.Collections.Generic;

namespace AddressBookApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contact/form"] = _ => {
        return View["contact_new.cshtml"];
      }
      Post["/contact/new"]

    }
  }
}
