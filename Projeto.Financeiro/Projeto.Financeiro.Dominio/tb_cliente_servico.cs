using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public  class tb_cliente_servico
    {
        [Display(Name = "Controle do Serviço:")]
        public int IDCLIENTESERVICO { get; set; }

        [Display(Name = "Comissão do Serviço:")]
        public Double COMISSAO_SERVICO { get; set; }

        [Display(Name = "Data do Contrato:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public Double DATA_CONTRATO { get; set; }

        [Display(Name = "Controle do Cliente/Fornecedor:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_cliente_fornecedor IDCLIENTEFORNECEDOR { get; set; }


        [Display(Name = "Controle do Produto/Serviço:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_produto_servico IDPRODUTO { get; set; }


        [Display(Name = "Nome do Parceiro:")]
        public virtual tb_usuario IDPARCEIRO { get; set; }

        [Display(Name = "Comissão do Parceiro:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal COMISSAO_PARCEIRO { get; set; }

        [Display(Name = "Nome do Vendedor:")]
        public virtual tb_usuario IDVENDEDOR { get; set; }

        [Display(Name = "Comissão do Vendedor:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal COMISSAO_VENDEDOR { get; set; }

        [Display(Name = "Nome do Advogado:")]
        public virtual tb_usuario IDADVOGADO { get; set; }

        [Display(Name = "Comissão do Advogado:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal COMISSAO_ADVOGADO { get; set; }


        [Display(Name = "Registro ativo ou Inativo")]
        public Char STATUS { get; set; }
        [Display(Name = "Data da Inclusão do Registro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATA_INC { get; set; }
        [Display(Name = "Data da Alteração do Registro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATA_ALT { get; set; }
    }
}
