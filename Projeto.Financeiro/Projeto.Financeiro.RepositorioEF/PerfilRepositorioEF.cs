using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;


namespace Projeto.Financeiro.RepositorioEF
{

    public class PerfilRepositorioEF : IRepositorio<tb_perfil>
    {

        private readonly Contexto contexto;

        public PerfilRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_perfil entidade)
        {
            if (entidade.IDPERFIL > 0)
            {
                //todo: falta campos perfil
                //var Alterar = contexto.ClienteServicoFornecedor.First(x => x.IDClienteServicoFornecedor == entidade.IDClienteServicoFornecedor);
                //Alterar.RAZAO_SOCIAL = entidade.RAZAO_SOCIAL;
                //Alterar.ENDERECO = entidade.ENDERECO;
                //Alterar.BAIRRO = entidade.BAIRRO;
                //Alterar.CIDADE = entidade.CIDADE;
                //Alterar.IMAGEM_LOGO = entidade.IMAGEM_LOGO;
                //Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Perfil.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_perfil entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Perfil.First(x => x.IDPERFIL == entidade.IDPERFIL);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_perfil>().Remove(ClienteServicoFornecedorExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_perfil ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Perfil.First(x => x.IDPERFIL == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_perfil> ListarTodos()
        {
            return contexto.Perfil.Where(x => x.STATUS != 'S');
        }


    }
}
