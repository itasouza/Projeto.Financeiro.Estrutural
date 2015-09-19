using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Financeiro.RepositorioEF
{
     public interface IEntidade
     {
        DateTime DATA_ALTERACAO { get; set; }
        DateTime DATA_INCLUSAO { get; set; }
     }
}
