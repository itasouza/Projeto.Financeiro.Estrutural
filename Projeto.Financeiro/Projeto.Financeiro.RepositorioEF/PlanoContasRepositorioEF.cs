using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class PlanoContasRepositorioEF : IRepositorio<tb_plano_contas>
    {

        private readonly Contexto contexto;

        public PlanoContasRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_plano_contas entidade)
        {
            if (entidade.IDPLANOCONTAS > 0)
            {

                //todo:falta dados do PlanoContas
                //    var Alterar = contexto.PlanoContas.First(x => x.IDPlanoContas == entidade.IDPlanoContas);
                //    Alterar.RAZAO_SOCIAL = entidade.RAZAO_SOCIAL;
                //    Alterar.ENDERECO = entidade.ENDERECO;
                //    Alterar.BAIRRO = entidade.BAIRRO;
                //    Alterar.CIDADE = entidade.CIDADE;
                //    Alterar.IMAGEM_LOGO = entidade.IMAGEM_LOGO;
                //    Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.PlanoContas.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_plano_contas entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.PlanoContas.First(x => x.IDPLANOCONTAS == entidade.IDPLANOCONTAS);
            Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_PlanoContas>().Remove(Excluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_plano_contas ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.PlanoContas.First(x => x.IDPLANOCONTAS == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_plano_contas> ListarTodos()
        {
            return contexto.PlanoContas.Where(x => x.STATUS != 'S');
        }


    }
}
