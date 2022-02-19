using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1," تاکسی","پروژه درخواست تاکسی آنلاین","project-1.jpg","Tap30"),
                new Project(2," زودفود","پروژه درخواست آنلاین غذا","project-2.jpg","ZoodFood"),
                new Project(3," مدارس","سیستم مدیریت یکپارچه مدارس","project-3.jpg","Monop"),
                new Project(4," پت شاپ","فروشگاه آنلاین فروش محصولات حیوانات خانگی","project-4.jpg","DogShop"),
            };
            return View("_Projects",projects);
        }
    }
}
