using Bulky.DataAcess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BulkyBookWeb.Controllers
{
    public class ReturnJsonController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReturnJsonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _unitOfWork.Category.GetAll();
            return new OkObjectResult(Json(objCategoryList).Value);
        }
    }
}
