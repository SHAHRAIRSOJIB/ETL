using ExelTechApi.Service.BussinessLayer.Interface;
using ExelTechApi.Service.Model;
using Microsoft.AspNetCore.Mvc;

namespace ExelTechAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DropDownController : Controller
    {
        private IDropDown _dropDown;
        public DropDownController(IDropDown dropDown)
        {
            _dropDown=dropDown; 
        }
        [HttpGet]
        [Route("GetAllDiseaseName")]
        public List<DiseaseInformation> GetAllDiseaseName()
        {
            var list = _dropDown.GetAllDiseaseName().ToList();
            return list;
        }
        [HttpGet]
        [Route("GetAllNCDList")]
        public List<NCD> GetAllNCDList()
        {

            var ncdLIst = _dropDown.GetAllNCDName().ToList();
            return ncdLIst;
        }
        [HttpGet]
        [Route("GetAllAllergyList")]
        public List<Allergy> GetAllAllergyList()
        {
            var ncdLIst = _dropDown.GetAllergies().ToList();
            return ncdLIst;
        }
    }
}
