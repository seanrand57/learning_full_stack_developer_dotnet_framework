using System.Linq;
using System.Web.Mvc;
using learning_full_stack_developer_dotnet_framework.Models;
using learning_full_stack_developer_dotnet_framework.ViewModels;

namespace learning_full_stack_developer_dotnet_framework.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}