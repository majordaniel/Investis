using Investis.DomainModel.GeneratedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Repository.Interfaces
{
    public interface ILoanApplication
    {
        void insertApplication(tb_BusinessApplications _BusinessApplications);
        void VerifyApplication(tb_BusinessApplications _BusinessApplications);
    }
}
