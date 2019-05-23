using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Asp.net.Models
{
    public class EmpregadoContexto : DbContext
    {
        //conexao com BD feita para os empregados
        public EmpregadoContexto(DbContextOptions<EmpregadoContexto> options) : base(options)
        {
        }
    }
}
