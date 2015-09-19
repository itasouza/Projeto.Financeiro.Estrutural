using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_empresa
    {
        [Display(Name = "Controle da Empresa:")]
        public int IDEMPRESA { get; set; }

        [Display(Name ="Nome / Razão Social da Empresa:")]
        [Required(ErrorMessage ="Campo Obrigatório:")]
        public string RAZAO_SOCIAL { get; set; }

        [Display(Name = "Endereço da Empresa:")]
        public String ENDERECO { get; set; }

        [Display(Name = "Bairro da Empresa:")]
        public String BAIRRO { get; set; }

        [Display(Name = "Cidade da Empresa:")]
        public String CIDADE { get; set; }

        [Display(Name = "Logo da Empresa:")]
        public byte[] IMAGEM_LOGO { get; set; }

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