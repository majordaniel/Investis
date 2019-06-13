using Investis.DomainModel.GeneratedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Repository.Interfaces
{
  public  interface IInvestment
    {
        void InserInvestment(tb_Investments _Investments);
        void UpdateInvestments(tb_Investments _Investments);

    }
}
