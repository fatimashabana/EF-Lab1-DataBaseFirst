using EF.DBF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DBF.BLL
{
   public class UnitOfWork
    {
        private static Entities context = new Entities();
        private static UnitOfWork unit ;

        private UnitOfWork()
        {
                
        }

        public static UnitOfWork create()
        {
            if(unit == null)
            {
                return new UnitOfWork();
            }
            return unit;
        }

        public CityManger CityManger {
            get
            {
                return new CityManger(context);
            }
                }

        public CountryManger CountryManger
        {
            get
            {
                return new CountryManger(context);
            }
        }
    }
}
