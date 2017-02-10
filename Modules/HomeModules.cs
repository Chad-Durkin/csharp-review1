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
      Post["/contact/new"] = _ => {
        Contact newContact = Contact(
        Request.Form["contact-name"],
        (Request.Form["contact-city"] + ", " + Request.Form["contact-state"] + " " + Request.Form["contact-street"] + ", " + Request.Form["contact-zipcode"]),
        Request.Form["contact-phone-number"]);
        return View["contact_new.cshtml", newContact]
      }

    }
  }
}
