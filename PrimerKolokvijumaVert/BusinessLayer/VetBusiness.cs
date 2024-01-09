using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VetBusiness
    {
        readonly VetsRepository vetsRepository = new VetsRepository();

        public List<Vet> GetAllVets()
        {
            return vetsRepository.GetAllVets();
        }

        public List<Vet> GetAllVetsAboveValue(int n)
        {
            return vetsRepository.GetAllVets().Where(i => i.YearsEperience > n).ToList();
        }

        public bool InsertVet(Vet vet)
        {
            return vetsRepository.InsertVet(vet) != 0;
        }
    }
}