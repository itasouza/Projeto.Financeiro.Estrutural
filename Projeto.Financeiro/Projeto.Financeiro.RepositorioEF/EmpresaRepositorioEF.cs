using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class EmpresaRepositorioEF : IRepositorio<tb_empresa>
    {

        private readonly Contexto contexto;

        public EmpresaRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_empresa entidade) 
        {
            if (entidade.IDEMPRESA > 0)
            {
                var Alterar = contexto.Empresa.First(x => x.IDEMPRESA == entidade.IDEMPRESA);
                Alterar.RAZAO_SOCIAL = entidade.RAZAO_SOCIAL;
                Alterar.ENDERECO = entidade.ENDERECO;
                Alterar.BAIRRO = entidade.BAIRRO;
                Alterar.CIDADE = entidade.CIDADE;
                Alterar.IMAGEM_LOGO = entidade.IMAGEM_LOGO;
                Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Empresa.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_empresa entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Empresa.First(x => x.IDEMPRESA == entidade.IDEMPRESA);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_empresa>().Remove(empresaExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_empresa ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Empresa.First(x => x.IDEMPRESA == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_empresa> ListarTodos()
        {
            return contexto.Empresa.Where(x => x.STATUS != 'S');
        }


    }
}
