using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Vet
    {
        public int Id;
        public string FullName;
        public string Speciality;
        public int YearsEperience;

        public Vet() { }

        public Vet(string fullName, string speciality, int yearsEperience)
        {
            FullName = fullName;
            Speciality = speciality;
            YearsEperience = yearsEperience;
        }
    }
}
