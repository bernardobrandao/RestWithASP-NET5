using System;
using RestWithASPNET.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long ind);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long Id);

    }
}
