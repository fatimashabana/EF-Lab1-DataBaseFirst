using EF.DBF.Model;
using EF.DBF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DBF.BLL
{
    public class CountryManger : Repository<Country, Entities>
    {
        public CountryManger(Entities context) : base(context)
        {
        }

        
    }
}
