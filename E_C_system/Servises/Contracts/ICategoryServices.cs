using E_C_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Servises.Contracts
{
    public interface ICategoryServices
    {
        Task<List<Category>> GetCategory();
    }
}
