using Nancy;
using System.Collections.Generic;
// using Contacts.Objects;

namespace Contacts.Modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["FormContact"] = _ => {
        return View["FormContact.cshtml"];
      };
      Post["FormContact"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        return View["ContactSuccess", newContact];
      }
    }
  }
}
