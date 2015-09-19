using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_recibo
    {
        [Display(Name = "Controle do Recibo:")]
        public int IDRECIBO { get; set; }

        [Display(Name = "Controle do Cliente/Fornecedor:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_cliente_fornecedor IDCLIENTEFORNECEDOR { get; set; }

        [Display(Name = "Valor Recebido:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal VALOR_RECIBO { get; set; }

        [Display(Name = "Valor por Extenso:")]
        public String VALOR_EXTENSO { get; set; }

        [Display(Name = "Observação:")]
        public String OBSERVACAO { get; set; }

        [Display(Name = "Nome da Cidade:")]
        public String CIDADE { get; set; }

        [Display(Name = "Data do Recibo:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public String DATA_RECIBO { get; set; }


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