using ExelTechApi.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.BussinessLayer.Interface
{
    public interface IPatient: IDisposable
    {
        public int Create(Patient patient);
        public Patient GetById(int id);
        public List<Patient> GetAll();
        public int DeleteById(int id);
        public int Update(Patient patient);
    }
}
