using System;
using System.Collections.Generic;
using IEL.Estagio.Domain.Interfaces.Validation;
using IEL.Estagio.Domain.Validation.Vagas;
using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Entities
{
    public class Empresa //: ISelfValidator
    {
        public Empresa()
        {
            //this.Tab_Empresa_boleto = new List<Tab_Empresa_boleto>();
            //this.Tab_Empresa_contato = new List<Tab_Empresa_contato>();
            //this.Tab_Empresa_convenio = new List<Tab_Empresa_convenio>();
            //this.Tab_Empresa_convenio_log = new List<Tab_Empresa_convenio_log>();
            //this.Tab_Empresa_Email = new List<Tab_Empresa_Email>();
            //this.Tab_Empresa_endereco = new List<Tab_Empresa_endereco>();
            //this.Tab_Empresa_endereco_log = new List<Tab_Empresa_endereco_log>();
            //this.Tab_Empresa_log = new List<Tab_Empresa_log>();
            //this.Tab_Empresa_ocorrencia = new List<Tab_Empresa_ocorrencia>();
            //this.Tab_Empresa_representante = new List<Tab_Empresa_representante>();
            //this.Tab_Empresa_representante_log = new List<Tab_Empresa_representante_log>();
            //this.Tab_Empresa_taxa = new List<Tab_Empresa_taxa>();
            //this.Tab_Empresa_taxa_log = new List<Tab_Empresa_taxa_log>();
            //this.Tab_Empresa_unidade = new List<Tab_Empresa_unidade>();
            //this.Tab_Faturamento = new List<Tab_Faturamento>();
            //this.Tab_Folha_pagamento = new List<Tab_Folha_pagamento>();
            //this.Tab_Tce = new List<Tab_Tce>();
            //this.Tab_UsuarioExterno_Empresa = new List<Tab_UsuarioExterno_Empresa>();
            this.Vaga = new List<Vaga>();
            //this.Tab_WebVaga = new List<Tab_WebVaga>();
        }

        public int idempresa { get; set; }
        public string cod_notes { get; set; }
        public string cnpj { get; set; }
        public string flg_pessoa_fisica { get; set; }
        public string num_registro_conselho { get; set; }
        public string nome_fantasia { get; set; }
        public string razao_social { get; set; }
        public string tipo_especial { get; set; }
        public string tipo_empresa { get; set; }
        public string porte { get; set; }
        public string site_web { get; set; }
        public Nullable<int> num_funcionarios { get; set; }
        public string horario_funcionamento { get; set; }
        public Nullable<int> idareaatuacao { get; set; }
        public string email_rh { get; set; }
        public string email_financeiro { get; set; }
        public string email_contrato { get; set; }
        public string email_dp { get; set; }
        public Nullable<int> idresponsavel { get; set; }
        public Nullable<System.DateTime> dt_visita_realizada { get; set; }
        public int unid_primeiro_cadastro { get; set; }
        public int unid_controle_taxa { get; set; }
        public string ativo { get; set; }
        public string flg_termo_devolvido { get; set; }
        public string flg_fatura_sem_tce_ass { get; set; }
        public string flg_bolsa_sem_tce_ass { get; set; }
        public System.DateTime dt_cadastro { get; set; }
        public string usu_cadastro { get; set; }
        public Nullable<System.DateTime> dt_alteracao { get; set; }
        public string usu_alteracao { get; set; }
        //public virtual Tab_Areaatuacao Tab_Areaatuacao { get; set; }
        //public virtual ICollection<Tab_Empresa_boleto> Tab_Empresa_boleto { get; set; }
        //public virtual ICollection<Tab_Empresa_contato> Tab_Empresa_contato { get; set; }
        //public virtual ICollection<Tab_Empresa_convenio> Tab_Empresa_convenio { get; set; }
        //public virtual ICollection<Tab_Empresa_convenio_log> Tab_Empresa_convenio_log { get; set; }
        //public virtual ICollection<Tab_Empresa_Email> Tab_Empresa_Email { get; set; }
        //public virtual ICollection<Tab_Empresa_endereco> Tab_Empresa_endereco { get; set; }
        //public virtual ICollection<Tab_Empresa_endereco_log> Tab_Empresa_endereco_log { get; set; }
        //public virtual ICollection<Tab_Empresa_log> Tab_Empresa_log { get; set; }
        //public virtual ICollection<Tab_Empresa_ocorrencia> Tab_Empresa_ocorrencia { get; set; }
        //public virtual ICollection<Tab_Empresa_representante> Tab_Empresa_representante { get; set; }
        //public virtual ICollection<Tab_Empresa_representante_log> Tab_Empresa_representante_log { get; set; }
        //public virtual ICollection<Tab_Empresa_taxa> Tab_Empresa_taxa { get; set; }
        //public virtual ICollection<Tab_Empresa_taxa_log> Tab_Empresa_taxa_log { get; set; }
        //public virtual ICollection<Tab_Empresa_unidade> Tab_Empresa_unidade { get; set; }
        //public virtual ICollection<Tab_Faturamento> Tab_Faturamento { get; set; }
        //public virtual ICollection<Tab_Folha_pagamento> Tab_Folha_pagamento { get; set; }
        //public virtual ICollection<Tab_Tce> Tab_Tce { get; set; }
        //public virtual ICollection<Tab_UsuarioExterno_Empresa> Tab_UsuarioExterno_Empresa { get; set; }
        public virtual ICollection<Vaga> Vaga { get; set; }
        //public virtual ICollection<Tab_WebVaga> Tab_WebVaga { get; set; }
        //public virtual Tab_Unidade Tab_Unidade { get; set; }
        //public virtual Tab_Unidade Tab_Unidade1 { get; set; }
        //public virtual Tab_Usuario Tab_Usuario { get; set; }

        //public ValidationResult ResultadoValidacao { get; private set; }
        //public bool IsValid()
        //{
        //    var fiscal = new VagaAptoParaCadastroNoSistema();
        //    ResultadoValidacao = fiscal.Validar(this);
        //    return ResultadoValidacao.IsValid;
        //}
    }
}
