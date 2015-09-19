using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.RepositorioEF;

namespace Projeto.Financeiro.Aplicacao
{
    public class EmpresaAplicacaoConstrutor
    {

        public static EmpresaAplicacao EmpresaRepositorioEF()
        {
            return new EmpresaAplicacao(new EmpresaRepositorioEF());
        }

    }
}
