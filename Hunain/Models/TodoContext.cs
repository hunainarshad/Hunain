﻿using Microsoft.EntityFrameworkCore;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoapi.Models
{
    
        public class TodoContext : DbContext
        {
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<Todoitem> TodoItems { get; set; }
        }
    
}
