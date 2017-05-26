using Nancy;
using System.Collections.Generic;
using ContactList.Objects;

namespace ContactList.Modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["FormContact"] = _ => {
        return View["FormContact.cshtml"];
      };
      Post["/ContactAdded"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        return View["ContactAdded.cshtml", newContact];
      };
      Get["/ContactInfo/{id}"] = parameter => {
        Contact contact = Contact.Find(parameter.id);
        return View["ContactInfo.cshtml", contact];
      };
      Post["/RemoveSuccess"] = _ => {
      Contact.ClearAll();
      return View["RemoveSuccess.cshtml"];
      };
    }
  }
}
