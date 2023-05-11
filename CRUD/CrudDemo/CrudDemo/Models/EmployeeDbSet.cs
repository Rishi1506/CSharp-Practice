﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDemo.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }
        DbSet<Employees> Employees
        {
            get;
            set;
        }
    }
}
