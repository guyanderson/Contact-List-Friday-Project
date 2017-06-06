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
        return View["Contact.cshtml", allContacts];
      };
      Get["/Contact/Form"] = _ => {
        return View["Contact_Form.cshtml"];
      };
      Post["/Contact/Added"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        return View["Contact_Added.cshtml", newContact];
      };
      Get["/Contact/Info/{id}"] = parameter => {
        Contact contact = Contact.Find(parameter.id);
        return View["Contact_Info.cshtml", contact];
      };
      Post["/Contact/Removed"] = _ => {
      Contact.ClearAll();
      return View["Contact_Removed.cshtml"];
      };
    }
  }
}
