using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.Aplicacao
{
    public class EmpresaAplicacao
    {
        private readonly IRepositorio<tb_empresa> repositorio;

        public EmpresaAplicacao(IRepositorio<tb_empresa> repo)
        {
            repositorio = repo;
        }

        //gravar o registro
        public void SalvarRegistro(tb_empresa empresa)
        {
            repositorio.SalvarRegistro(empresa);
        }

        //excluir o registro
        public void ExcluirRegistro(tb_empresa empresa)
        {
            repositorio.ExcluirRegistro(empresa);
        }

        //listar todos
        public IEnumerable<tb_empresa> ListarTodos()
        {
            return repositorio.ListarTodos();
        }


        //listar por id
        public tb_empresa ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
