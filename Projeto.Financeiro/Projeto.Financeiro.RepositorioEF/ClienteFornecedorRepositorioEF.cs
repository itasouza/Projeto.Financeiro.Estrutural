using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class ClienteFornecedorRepositorioEF : IRepositorio<tb_cliente_fornecedor>
    {

        private readonly Contexto contexto;

        public ClienteFornecedorRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_cliente_fornecedor entidade)
        {
            if (entidade.IDCLIENTEFORNECEDOR > 0)
            {

                var Alterar = contexto.ClienteFornecedor.First(x => x.IDCLIENTEFORNECEDOR == entidade.IDCLIENTEFORNECEDOR);
                Alterar.CODIGO = entidade.CODIGO;
                Alterar.TIPO = entidade.TIPO;
                Alterar.RAZAO_SOCIAL = entidade.RAZAO_SOCIAL;
                Alterar.ENDERECO = entidade.ENDERECO;
                Alterar.NUMERO = entidade.NUMERO;
                Alterar.COMPLEMENTO = entidade.COMPLEMENTO;
                Alterar.BAIRRO = entidade.BAIRRO;
                Alterar.TELEFONE = entidade.TELEFONE;
                Alterar.CELULAR = entidade.CELULAR;
                Alterar.CIDADE = entidade.CIDADE;
                Alterar.UF = entidade.UF;
                Alterar.CEP = entidade.CEP;
                Alterar.CNPJ = entidade.CNPJ;
                Alterar.NOME_ADMINISTRADOR = entidade.NOME_ADMINISTRADOR;
                Alterar.DATA_NASCIMENTO = entidade.DATA_NASCIMENTO;
                Alterar.EMAIL = entidade.EMAIL;
                Alterar.MSN = entidade.MSN;
                Alterar.SKYPE = entidade.SKYPE;
                Alterar.HOME_PAGE = entidade.HOME_PAGE;
                Alterar.CONTADOR_ESCRITORIO = entidade.CONTADOR_ESCRITORIO;
                Alterar.CONTADOR_NOME = entidade.CONTADOR_NOME;
                Alterar.CONTADOR_TELEFONE = entidade.CONTADOR_TELEFONE;
                Alterar.CONTADOR_CELULAR = entidade.CONTADOR_CELULAR;
                Alterar.CONTADOR_EMAIL = entidade.CONTADOR_EMAIL;
                Alterar.DESPACHANTE_NOME = entidade.DESPACHANTE_NOME;
                Alterar.DESPACHANTE_TELEFONE = entidade.DESPACHANTE_TELEFONE;
                Alterar.DESPACHANTE_CELULAR = entidade.DESPACHANTE_CELULAR;
                Alterar.DESPACHANTE_EMAIL = entidade.DESPACHANTE_EMAIL;
                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.IDUSUARIO = entidade.IDUSUARIO;
                Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.ClienteFornecedor.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_cliente_fornecedor entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.ClienteFornecedor.First(x => x.IDCLIENTEFORNECEDOR == entidade.IDCLIENTEFORNECEDOR);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_cliente_fornecedor>().Remove(ClienteFornecedorExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_cliente_fornecedor ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.ClienteFornecedor.First(x => x.IDCLIENTEFORNECEDOR == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_cliente_fornecedor> ListarTodos()
        {
            return contexto.ClienteFornecedor.Where(x => x.STATUS != 'S');
        }


    }
}
