using System;
using RestWithASPNET.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long ind);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);

    }
}
