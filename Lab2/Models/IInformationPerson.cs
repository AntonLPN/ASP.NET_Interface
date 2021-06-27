using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
   public interface IInformationPerson
    {

        List<Person> GetPeople(IEnumerable<Person> people);

        List<string> GetName(List<Person> people);

    }
}
