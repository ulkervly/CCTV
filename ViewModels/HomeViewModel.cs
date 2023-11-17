using CCTV_MVC.Models;

namespace CCTV_MVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set;}
        public List<SecurityService> SecurityServices { get; set;}
        public List<TeamMembers> TeamMembers { get; set;}
    }
}
