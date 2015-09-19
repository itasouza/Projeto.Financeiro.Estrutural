using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_plano_contas
    {
        [Display(Name = "Controle do Plano de Contas:")]
        public int IDPLANOCONTAS { get; set; }


        [Display(Name = "Número da Conta:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public string NUMERO_CONTA { get; set; }


        [Display(Name = "Descrição da Conta:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String DESCRICAO_CONTA { get; set; }


        [Display(Name = "Operação (Débito/Crédito):")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String OPERACAO { get; set; }



        //dados de vinculo com empresa é perfil
        [Display(Name = "Selecione a Empresa:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_empresa IDEMPRESA { get; set; }

        [Display(Name = "Selecione o Perfil de Acesso:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_perfil IDPERFIL { get; set; }
        //dados de vinculo com empresa é perfil


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