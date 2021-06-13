using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class ContactController : Controller
    {
         ContactManager cm = new ContactManager(new EfContactDal());
         ContactValidator cv = new ContactValidator();

        public ActionResult Index()
        {
            var contactvalues = cm.GetAll();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetById(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
           

            return PartialView();
        }
    }
}