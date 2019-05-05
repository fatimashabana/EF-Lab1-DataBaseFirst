using EF.DBF.BLL;
using EF.DBF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataBaseFirstModel
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = UnitOfWork.create();
           var c= unitOfWork.CountryManger.Add(new Country{ Name="USA"});
        }
    }
}
 