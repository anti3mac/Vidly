using System;
using Vidly.Models;

namespace Vidly.Controllers
{
    internal class AplicationDbContext
    {
        public static implicit operator AplicationDbContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}