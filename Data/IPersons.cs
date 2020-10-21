using System.Collections.Generic;
using LoginExample.Data.Impl;

namespace LoginExample.Data
{
    public interface IPersons
    {
        List<Adult> GetPersons();

        void AddPerson(Adult person);

        void RemovePerson(int id);

        
    }
}