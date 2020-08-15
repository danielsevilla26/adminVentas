using AdminVentas.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminVentas.DataAccess
{
    public class AdminVentasDBContext : DbContext, IAdminVentasDBContext
    {
        public AdminVentasDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
