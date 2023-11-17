using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using CCTV_MVC.Models;
using CCTV_MVC.ViewModels;

namespace CCTV_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            
            _context = context;
        }
        public IActionResult Index()
        {
          
            List<SecurityService> securityServices = new List<SecurityService>();
            SecurityService SecurityService1 = new SecurityService() { Id = 1, Title1 = "Title 1",Title2="New Title 2" ,Description = "Descservice1", RedirectUrl = "https://google.com" };
            SecurityService SecurityService2 = new SecurityService() { Id = 2, Title1 = "Title 2", Title2=" New Title 2",Description = "Descservice2",  RedirectUrl = "https://google.com" };

            securityServices.Add(SecurityService1);
            securityServices.Add(SecurityService2);

            List<TeamMembers> teamMembers = new List<TeamMembers>();
            TeamMembers teamMembers1 = new TeamMembers() { Id = 1, FullName = "F1", Profession = "P1" };
            TeamMembers teamMembers2 = new TeamMembers() { Id = 2, FullName = "F2", Profession = "P2" };

            
            HomeViewModel homevm = new HomeViewModel();
            homevm.Sliders = _context.Sliders.ToList();
           homevm.SecurityServices= securityServices;
            homevm.TeamMembers= teamMembers;
            return View(homevm);


        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
    
        public IActionResult Contact()
        {
            return View();
        }
    }
}
