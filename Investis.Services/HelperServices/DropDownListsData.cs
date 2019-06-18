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
        InvestisDBEntities db = new InvestisDBEntities();
        public object CountryListDropDown()
        {
            //List<tb_Country> Countries = db.tb_Country.ToList(); 
           var  Countries = from countr in db.tb_Country
                                         select new AllCountries
                                         {
                                             CountryID = countr.CountryID,
                                             CountryName = countr.CountryName
                                         };
            
            return Countries.ToList();
        }
    }

    internal class AllCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
