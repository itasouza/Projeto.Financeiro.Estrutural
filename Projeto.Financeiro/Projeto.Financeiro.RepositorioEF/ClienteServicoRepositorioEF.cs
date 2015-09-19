using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;


namespace Projeto.Financeiro.RepositorioEF
{

    public class ClienteServicoRepositorioEF : IRepositorio<tb_cliente_servico>
    {

        private readonly Contexto contexto;

        public ClienteServicoRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_cliente_servico entidade)
        {
            if (entidade.IDCLIENTESERVICO > 0)
            {

                //todo:falta dados do ClienteServico
                //    var Alterar = contexto.ClienteServico.First(x => x.IDClienteServico == entidade.IDClienteServico);
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
                contexto.ClienteServico.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_cliente_servico entidade)
        {
            //não vou excluir o registro
            var Excluir = contexto.ClienteServico.First(x => x.IDCLIENTESERVICO == entidade.IDCLIENTESERVICO);
            contexto.Set<tb_cliente_servico>().Remove(Excluir);
            contexto.SaveChanges();
        }

        //listar por id os registros
        public tb_cliente_servico ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.ClienteServico.First(x => x.IDCLIENTESERVICO == idInt);
            return Consulta;
        }

        //listar todos os registros 
        public IEnumerable<tb_cliente_servico> ListarTodos()
        {
            return contexto.ClienteServico;
        }


    }
}
