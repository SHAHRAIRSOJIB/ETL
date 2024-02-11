using ExelTechApi.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.BussinessLayer.Interface
{
    public interface IDropDown : IDisposable
    {
        public List<DiseaseInformation> GetAllDiseaseName();
        public List<NCD> GetAllNCDName();
        public List<Allergy> GetAllergies();
    }
}
