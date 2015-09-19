using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
   public class tb_boleto_emitido
    {
        [Display(Name = "Controle do Boleto:")]
        public int IDBOLETO { get; set; }

        [Display(Name = "Controle do Cliente/Fornecedor:")]
        public virtual tb_cliente_fornecedor IDCLIENTEFORNECEDOR { get; set; }

        [Display(Name = "Data de Vencimento:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATA_VENCIMENTO { get; set; }

        [Display(Name = "Valor do Boleto:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal VALOR_BOLETO { get; set; }

        [Display(Name = "Percentual do Juros:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PERCENTUAL_JUROS { get; set; }

        [Display(Name = "Percentual Multa:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PERCENTUAL_MULTA { get; set; }

        [Display(Name = "Percentual Desconto:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PERCENTUAL_DESCONTO { get; set; }

        [Display(Name = "Outros Acréscimos:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal OUTROS_ACRESCIMOS { get; set; }

        [Display(Name = "Demonstrativo:")]
        public String DEMONSTRATIVO { get; set; }

        [Display(Name = "Instruções Caixa:")]
        public String INSTRUCOES_CAIXA { get; set; }

        [Display(Name = "Nosso Número:")]
        public String NOSSO_NUMERO { get; set; }

        [Display(Name = "Data do Pagamento:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATA_PAGAMENTO { get; set; }


        [Display(Name = "Valor Pago:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal VALOR_PAGO { get; set; }


        //dados de vinculo com empresa é usuário
        [Display(Name = "Controle da Empresa:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_empresa IDEMPRESA { get; set; }


        [Display(Name = "Controle do Usuário:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_usuario IDUSUARIO { get; set; }
        //dados de vinculo com empresa é usuário

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
