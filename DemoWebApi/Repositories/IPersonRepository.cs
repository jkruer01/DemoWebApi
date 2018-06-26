using DemoWebApi.Models;
using System.Collections.Generic;

namespace DemoWebApi.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Get();
    }
}
