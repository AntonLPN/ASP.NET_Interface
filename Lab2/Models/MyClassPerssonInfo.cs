using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class MyClassPerssonInfo : IInformationPerson
    {
        public List<Person> GetPeople(IEnumerable<Person> people)
        {
            return people.ToList<Person>();
        }
        /// <summary>
        /// Возвращает список имен
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public List<string> GetName(List<Person> people)
        {

           
            var wantedList = people.Select(p => p.LastName);

            return wantedList.ToList(); 
        }


      
    }
}