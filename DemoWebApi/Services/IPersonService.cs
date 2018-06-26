using DemoWebApi.Models;
using System.Collections.Generic;

namespace DemoWebApi.Services
{
    public interface IPersonService
    {
        List<Person> Get(PersonRequest personRequest);
    }
}
