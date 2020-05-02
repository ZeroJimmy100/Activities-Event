using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivitiesEvent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace ActivitiesEvent.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context){
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        // Register User
        [HttpPost("Register")]

        public IActionResult Register(WrapperViewModel user){
        Users NewUser2 = user.NewUser;
        if(ModelState.IsValid){
            if(dbContext.TheUsers.Any(u => u.Email == NewUser2.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
                return View("Index");
            }


                PasswordHasher<Users> Hasher = new PasswordHasher<Users>();
                NewUser2.PassWord = Hasher.HashPassword(user.NewUser, NewUser2.PassWord);

                dbContext.Add(NewUser2);
                dbContext.SaveChanges();

                int? IDvariable = HttpContext.Session.GetInt32("UserID");
                
                HttpContext.Session.SetInt32("UserID", NewUser2.UserId);

                return RedirectToAction("Success", new {UserId = NewUser2.UserId});
            
        }
        else{
            
            return View("Index");
        }
    }

        // Success login User
        [HttpPost("Login/Success")]
        public IActionResult LogUser(WrapperViewModel userSubmission){
            Login LoginUser2 = userSubmission.LoginUser;
             if(ModelState.IsValid)
            {

                Users userInDb = dbContext.TheUsers.FirstOrDefault(u => u.Email == LoginUser2.Email);


                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
               
                var hasher = new PasswordHasher<Login>();

                var result = hasher.VerifyHashedPassword(LoginUser2, userInDb.PassWord, LoginUser2.PassWord);

                int? IDvariable = HttpContext.Session.GetInt32("UserID");

                HttpContext.Session.SetInt32("UserID", userInDb.UserId);
                
                if(result == 0){
                    ModelState.AddModelError("PassWord", "Password is invalid");
                    return View("Index");
                }
                return RedirectToAction("Success", new {UserId = userInDb.UserId });
            }
            return View("Index");
        }

        [HttpPost("Logout")]
        public IActionResult Logout(){
        HttpContext.Session.Clear();
        return View("Index");
    }

    [HttpGet("Dashboard/{UserId}")]
    public IActionResult Success(int UserId){

        
        WrapperViewModel allInfo = new WrapperViewModel();

        List<FormEvent> ListEvent = dbContext.EventForms.Include(g => g.Attending).OrderBy(d => d.Date).ToList();

        Users thisUser = dbContext.TheUsers.FirstOrDefault(u => u.UserId == UserId);

        allInfo.NewUser = thisUser;

        List<Users> ListUsers = dbContext.TheUsers.ToList();

        allInfo.ListEvents = ListEvent;

        List<Associates> ListAssociated = dbContext.AssociatesGuest.ToList();

        allInfo.ListAssociates = ListAssociated;
        
        int? IDvariable = HttpContext.Session.GetInt32("UserID");

        if(IDvariable != UserId){
            return View("Index");
        }

        return View("Dashboard", allInfo);
    }

    [HttpGet("AddEvent/{UserId}")]
    public IActionResult EventForm(WrapperViewModel allInfo, int UserId){

        Users thisUser = dbContext.TheUsers.FirstOrDefault(u => u.UserId == UserId);

        allInfo.NewUser = thisUser;

        return View("NewEvent", allInfo);
    }

     [HttpPost("CreateEvent/{UserId}")]
    public IActionResult CreateEvent(WrapperViewModel NewForm, int UserId)
    {
        FormEvent submittedForm = NewForm.NewEventForm;

        DateTime DefaultTime = DateTime.Today;

        Users thisUser = dbContext.TheUsers.FirstOrDefault(u => u.UserId == UserId);

        NewForm.NewUser = thisUser;

        submittedForm.UserId = NewForm.NewUser.UserId;

        if(ModelState.IsValid)
        {

            if(submittedForm.Date < DefaultTime){
                ModelState.AddModelError("Date", "Date must held in the future!");
                ViewBag.Error = "Date must be held in the future!";
                return View("NewEvent", NewForm);
            }

            dbContext.Add(submittedForm);
            dbContext.SaveChanges();
            return RedirectToAction("ViewEvent2", new {EventFormId = submittedForm.EventFormId});
        }else{
            return View("NewEvent", NewForm);
        }
    }

      [HttpGet("Event/{EventFormId}")]
    public IActionResult ViewEvent2(WrapperViewModel EventInfo, int EventFormId)
    {
       
        FormEvent thisEvent = dbContext.EventForms.FirstOrDefault(e => e.EventFormId == EventFormId);

        Users thisUser = dbContext.TheUsers.FirstOrDefault(u => u.UserId == thisEvent.UserId);

        Associates EventGuest = dbContext.AssociatesGuest.FirstOrDefault(e => e.EventFormId == EventFormId);

        EventInfo.NewUser = thisUser;

        EventInfo.NewEventForm = thisEvent;

        EventInfo.NewAssociates = EventGuest;

        return View("OwnEvent", EventInfo);
    }

    [HttpGet("Event/{EventFormId}/{UserId}")]
    public IActionResult ViewEvent(WrapperViewModel EventInfo, int EventFormId, int UserId)
    {
        Users thisUser = dbContext.TheUsers.FirstOrDefault(u => u.UserId == UserId);
        FormEvent thisEvent = dbContext.EventForms.Include(g => g.Attending).FirstOrDefault(e => e.EventFormId == EventFormId);

        thisEvent.Attending = dbContext.AssociatesGuest.Where(g => g.EventFormId == EventFormId).ToList();

        List<FormEvent> ListofForms = dbContext.EventForms.Include(g => g.Attending)
        .ThenInclude(b => b.User).ToList();
        
        List<Associates> EventGuest = dbContext.AssociatesGuest.ToList();

        Users SecondUser = dbContext.TheUsers.FirstOrDefault(u => u.UserId == thisEvent.UserId);

        EventInfo.NewUser = thisUser;

        EventInfo.NewEventForm = thisEvent;

        EventInfo.ListAssociates = EventGuest;

        EventInfo.ListEvents = ListofForms;

        EventInfo.SecondUser = SecondUser;
        

        return View("ViewEvent", EventInfo);
    }

    [HttpPost("AddGuest/{EventFormId}/{UserId}")]
    public IActionResult AttendEvent(Associates AddGuest, int EventFormId, int UserId)
    {
        
        AddGuest.UserId = UserId;

        AddGuest.EventFormId = EventFormId;

        dbContext.Add(AddGuest);
        dbContext.SaveChanges();

        return RedirectToAction("Success", new {UserId = AddGuest.UserId});
    }

    [HttpPost("UnattendGuest/{EventFormId}/{UserId}")]
    public IActionResult UnAttendEvent(Associates Unattend, int EventFormId, int UserId)
    {

        Unattend = dbContext.AssociatesGuest.LastOrDefault(a => a.UserId == UserId && a.EventFormId == EventFormId);
        
        Unattend.EventFormId = EventFormId;
        Unattend.UserId = UserId;
        
        dbContext.Remove(Unattend);
        dbContext.SaveChanges();
        return RedirectToAction("Success", new {UserId = UserId});
    }



    [HttpGet("DeleteEvent/{EventFormId}/{UserId}")]
    public IActionResult DeleteEvent(int EventFormId, int UserId){
        FormEvent retrieveEvent = dbContext.EventForms.SingleOrDefault(e => e.EventFormId == EventFormId);
        dbContext.EventForms.Remove(retrieveEvent);
        dbContext.SaveChanges();
        return RedirectToAction("Success", new {UserId = UserId});
    }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
