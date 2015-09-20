using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<tb_usuario>
    {

        private readonly Contexto contexto;

        public UsuarioRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_usuario entidade)
        {
            if (entidade.IDUSUARIO > 0)
            {

               var Alterar = contexto.Usuario.First(x => x.IDUSUARIO == entidade.IDUSUARIO);

                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.IDPERFIL = entidade.IDPERFIL;
                Alterar.NOME_USUARIO = entidade.NOME_USUARIO;
                Alterar.TELEFONE = entidade.TELEFONE;
                Alterar.EMAIL = entidade.EMAIL;
                Alterar.CELULAR = entidade.CELULAR;
                Alterar.VENDEDOR = entidade.VENDEDOR;
                Alterar.PARCEIRO = entidade.PARCEIRO;
                Alterar.JURIDICO = entidade.JURIDICO;
                Alterar.ENDERECO = entidade.ENDERECO;
                Alterar.NUMERO = entidade.NUMERO;
                Alterar.COMPLEMENTO = entidade.COMPLEMENTO;
                Alterar.BAIRRO = entidade.BAIRRO;
                Alterar.CIDADE = entidade.CIDADE;
                Alterar.CEP = entidade.CEP;
                Alterar.CNPJ = entidade.CNPJ;
                Alterar.CPF = entidade.CPF;
                Alterar.SENHA = entidade.SENHA;
                Alterar.LOGIN = entidade.LOGIN;
                Alterar.STATUS = entidade.STATUS;


                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Usuario.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_usuario entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Usuario.First(x => x.IDUSUARIO == entidade.IDUSUARIO);
            Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_ProdutoServico>().Remove(ProdutoServicoExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_usuario ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Usuario.First(x => x.IDUSUARIO == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_usuario> ListarTodos()
        {
            return contexto.Usuario.Where(x => x.STATUS != 'S');
        }


    }
}
