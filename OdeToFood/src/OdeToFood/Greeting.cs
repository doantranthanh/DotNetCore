using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeting
    {
        string GetGreeting();
    }

    public class Greeting : IGreeting
    {
        private string _greeting;

        public Greeting(IConfiguration configuration)
        {
            _greeting = configuration["Greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
