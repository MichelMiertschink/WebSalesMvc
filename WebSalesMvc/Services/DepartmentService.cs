﻿using Microsoft.EntityFrameworkCore;
using WebSalesMvc.Data;
using WebSalesMvc.Models;

namespace WebSalesMvc.Services
{
    public class DepartmentService
    {
        private WebSalesMvcContext _context;

        public DepartmentService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
