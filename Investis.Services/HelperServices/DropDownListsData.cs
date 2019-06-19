using Investis.DomainModel.GeneratedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Services.HelperServices
{
    
    public class DropDownListsData
    {
        InvestisDBEntities db;
        public DropDownListsData()
        {
            db = new InvestisDBEntities();
        }
   
        public List<tb_Country> CountryListDropDown()
        {
            List<tb_Country> Countries = db.tb_Country.ToList();

            return Countries;
        }
    }

  
}
