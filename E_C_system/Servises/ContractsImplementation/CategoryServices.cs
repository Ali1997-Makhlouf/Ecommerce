using E_C_system.Data;
using E_C_system.Models;
using E_C_system.Servises.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Servises.ContractsImplementation
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ApplicationDbContext _context;
        public CategoryServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategory()
        {
            return await _context.Category.Where(s => s.IsActive == true && s.IsDeleted != true && s.ParentId==null)
                            .ToListAsync();

        }
    }
}
