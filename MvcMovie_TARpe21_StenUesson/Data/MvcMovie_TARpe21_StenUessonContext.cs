using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_TARpe21_StenUesson.Models;

namespace MvcMovie_TARpe21_StenUesson.Data
{
    public class MvcMovie_TARpe21_StenUessonContext : DbContext
    {
        public MvcMovie_TARpe21_StenUessonContext (DbContextOptions<MvcMovie_TARpe21_StenUessonContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_TARpe21_StenUesson.Models.Movies> Movie { get; set; }
    }
}
