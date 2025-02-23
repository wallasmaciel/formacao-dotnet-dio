using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modulo_api.Entities;

namespace modulo_api.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        public DbSet<Contato> Contatos { get; set; }
    }
}