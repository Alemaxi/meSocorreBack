using Domain.core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlInfrastructure
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hospital> Hospitais { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<HospitalXEspecialidade> HospitaisXEspecialidades { get; set; }
        public DbSet<HospitalXExame> HospitaisXExames { get; set; }
    }
}
