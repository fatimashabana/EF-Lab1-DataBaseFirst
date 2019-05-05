using EF.DBF.Model;
using EF.DBF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DBF.BLL
{
    public class CityManger : Repository<City, Entities>
    {
        public CityManger(Entities context) : base(context)
        {
        }
    }
}
