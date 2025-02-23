using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_mvc.Models;

namespace projeto_mvc.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        public DbSet<Contato> Contatos { get; set; }
    }
}