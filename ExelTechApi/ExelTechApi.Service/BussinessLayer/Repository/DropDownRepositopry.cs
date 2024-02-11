using ExelTechApi.Service.BussinessLayer.Interface;
using ExelTechApi.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.BussinessLayer.Repository
{
    public class DropDownRepositopry:IDropDown
    {
        private readonly ExelTechDbContext _context;
        public DropDownRepositopry(ExelTechDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<DiseaseInformation> GetAllDiseaseName()
        {
            try
            {
                var diseaseList = _context.DiseaseInformation.ToList();
                return diseaseList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<NCD> GetAllNCDName()
        {
            try
            {
                var ncdList = _context.NCDs.ToList();
                return ncdList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Allergy>GetAllergies()
        {
            try
            {
                var allergyList = _context.Allergies.ToList();
                return allergyList; 
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
