using System;
using System.Collections.Generic;
using IEL.Estagio.Domain.Interfaces.Validation;
using IEL.Estagio.Domain.Validation.Vagas;
using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Entities
{
    public class Vaga : ISelfValidator
    {
        public Vaga()
        {
            //this.Tab_Estudante_historico = new List<Tab_Estudante_historico>();
            //this.Tab_Solicitacao_Vaga = new List<Tab_Solicitacao_Vaga>();
            //this.Tab_Tce = new List<Tab_Tce>();
            //this.Tab_Vaga_acompanhamento = new List<Tab_Vaga_acompanhamento>();
            //this.Tab_Vaga_Agendado = new List<Tab_Vaga_Agendado>();
            //this.Tab_Vaga_atividade = new List<Tab_Vaga_atividade>();
            //this.Tab_Vaga_cancelada_log = new List<Tab_Vaga_cancelada_log>();
            //this.Tab_Vaga_curso = new List<Tab_Vaga_curso>();
            //this.Tab_Vaga_cursobasico = new List<Tab_Vaga_cursobasico>();
            //this.Tab_Vaga_Email = new List<Tab_Vaga_Email>();
            //this.Tab_Vaga_Encaminhado = new List<Tab_Vaga_Encaminhado>();
            //this.Tab_Vaga_Encaminhado_Dispensado = new List<Tab_Vaga_Encaminhado_Dispensado>();
            //this.Tab_Vaga_expectativa = new List<Tab_Vaga_expectativa>();
            //this.Tab_Vaga_informatica = new List<Tab_Vaga_informatica>();
            //this.Tab_Vaga_instituicao = new List<Tab_Vaga_instituicao>();
            //this.Tab_Vaga_instituto = new List<Tab_Vaga_instituto>();
            //this.Tab_Vaga_linguaestrangeira = new List<Tab_Vaga_linguaestrangeira>();
            //this.Tab_Vaga_ocorrencia = new List<Tab_Vaga_ocorrencia>();
            //this.Tab_Vaga_PreConvocado = new List<Tab_Vaga_PreConvocado>();
            //this.Tab_Vaga_Selecionado = new List<Tab_Vaga_Selecionado>();
            //this.Tab_Vaga_Selecionado_Dispensado = new List<Tab_Vaga_Selecionado_Dispensado>();
        }

        public int idvaga { get; set; }
        public int idempresa { get; set; }
        public int idareaestagio { get; set; }
        public int idunidade { get; set; }
        public string cod_notes { get; set; }
        public string tipo_vaga { get; set; }
        public string flg_publica_web { get; set; }
        public string flg_ativo { get; set; }
        public int qtd_vagas { get; set; }
        public int qtd_max_vagas { get; set; }
        public string pode_candidatar { get; set; }
        public int qtd_vagas_candidatar { get; set; }
        public int qtd_vaga_cancelada { get; set; }
        public string contato { get; set; }
        public string ddd_telefone { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string contato2 { get; set; }
        public string ddd_telefone2 { get; set; }
        public string telefone2 { get; set; }
        public string email2 { get; set; }
        public string bairro { get; set; }
        public string num_na_empresa { get; set; }
        public string sexo { get; set; }
        public string pre_req_adicional { get; set; }
        public string necessita_habilitacao { get; set; }
        public string possuir_veiculo { get; set; }
        public string deficiente { get; set; }
        public string tipo_deficiente { get; set; }
        public string observacao { get; set; }
        public string testes_aplicados { get; set; }
        public Nullable<int> duracao { get; set; }
        public string turno { get; set; }
        public string descr_a_combinar { get; set; }
        public Nullable<System.DateTime> hora_inicio { get; set; }
        public Nullable<System.DateTime> hora_fim { get; set; }
        public Nullable<System.DateTime> hora_almoco_ini { get; set; }
        public Nullable<System.DateTime> hora_almoco_fim { get; set; }
        public string ch_dia { get; set; }
        public string dias_semana { get; set; }
        public string por_semana { get; set; }
        public string possibilidade_contratacao { get; set; }
        public Nullable<System.DateTime> dt_recesso_inicio { get; set; }
        public Nullable<System.DateTime> dt_recesso_fim { get; set; }
        public Nullable<System.DateTime> dt_recesso_inicio2 { get; set; }
        public Nullable<System.DateTime> dt_recesso_fim2 { get; set; }
        public Nullable<decimal> valor_bolsa { get; set; }
        public Nullable<decimal> valor_transporte { get; set; }
        public string transporte { get; set; }
        public string alimentacao { get; set; }
        public string outros_beneficios { get; set; }
        public string supervisor { get; set; }
        public string cargo_supervisor { get; set; }
        public string obs_caracteristica { get; set; }
        public string atividades { get; set; }
        public string expectativa_aprendizagem { get; set; }
        public Nullable<System.DateTime> dt_abertura { get; set; }
        public Nullable<System.DateTime> dt_suspensao { get; set; }
        public string motivo_suspensao { get; set; }
        public Nullable<System.DateTime> dt_fechamento { get; set; }
        public Nullable<System.DateTime> dt_prox_acompanhamento { get; set; }
        public Nullable<int> idmotivo_cancelamento { get; set; }
        public Nullable<System.DateTime> dt_ult_cancelamento { get; set; }
        public string usu_cancelamento { get; set; }
        public Nullable<int> idresponsavel { get; set; }
        public System.DateTime dt_cadastro { get; set; }
        public string usu_cadastro { get; set; }
        public Nullable<System.DateTime> dt_alteracao { get; set; }
        public string usu_alteracao { get; set; }
        public string flg_permite_formandos { get; set; }
        public int idperfilvaga { get; set; }
        public decimal valor_sel_diferenciada { get; set; }
        public Nullable<int> supervisor_idconselhoprof { get; set; }
        public string supervisor_num_conselhoprof { get; set; }
        public Nullable<int> idwebvaga { get; set; }
        //public virtual Tab_Areaestagio Tab_Areaestagio { get; set; }
        //public virtual Tab_ConselhoProfissional Tab_ConselhoProfissional { get; set; }
        public virtual Empresa Empresa { get; set; }
        //public virtual ICollection<Tab_Estudante_historico> Tab_Estudante_historico { get; set; }
        //public virtual Tab_Motivo Tab_Motivo { get; set; }
        //public virtual Tab_Perfil_Vaga Tab_Perfil_Vaga { get; set; }
        //public virtual ICollection<Tab_Solicitacao_Vaga> Tab_Solicitacao_Vaga { get; set; }
        //public virtual ICollection<Tab_Tce> Tab_Tce { get; set; }
        //public virtual Tab_Unidade Tab_Unidade { get; set; }
        //public virtual Tab_Usuario Tab_Usuario { get; set; }
        //public virtual ICollection<Tab_Vaga_acompanhamento> Tab_Vaga_acompanhamento { get; set; }
        //public virtual ICollection<Tab_Vaga_Agendado> Tab_Vaga_Agendado { get; set; }
        //public virtual ICollection<Tab_Vaga_atividade> Tab_Vaga_atividade { get; set; }
        //public virtual ICollection<Tab_Vaga_cancelada_log> Tab_Vaga_cancelada_log { get; set; }
        //public virtual ICollection<Tab_Vaga_curso> Tab_Vaga_curso { get; set; }
        //public virtual ICollection<Tab_Vaga_cursobasico> Tab_Vaga_cursobasico { get; set; }
        //public virtual ICollection<Tab_Vaga_Email> Tab_Vaga_Email { get; set; }
        //public virtual ICollection<Tab_Vaga_Encaminhado> Tab_Vaga_Encaminhado { get; set; }
        //public virtual ICollection<Tab_Vaga_Encaminhado_Dispensado> Tab_Vaga_Encaminhado_Dispensado { get; set; }
        //public virtual ICollection<Tab_Vaga_expectativa> Tab_Vaga_expectativa { get; set; }
        //public virtual ICollection<Tab_Vaga_informatica> Tab_Vaga_informatica { get; set; }
        //public virtual ICollection<Tab_Vaga_instituicao> Tab_Vaga_instituicao { get; set; }
        //public virtual ICollection<Tab_Vaga_instituto> Tab_Vaga_instituto { get; set; }
        //public virtual ICollection<Tab_Vaga_linguaestrangeira> Tab_Vaga_linguaestrangeira { get; set; }
        //public virtual ICollection<Tab_Vaga_ocorrencia> Tab_Vaga_ocorrencia { get; set; }
        //public virtual ICollection<Tab_Vaga_PreConvocado> Tab_Vaga_PreConvocado { get; set; }
        //public virtual ICollection<Tab_Vaga_Selecionado> Tab_Vaga_Selecionado { get; set; }
        //public virtual ICollection<Tab_Vaga_Selecionado_Dispensado> Tab_Vaga_Selecionado_Dispensado { get; set; }
        //public virtual Tab_WebVaga Tab_WebVaga { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }
        public bool IsValid()
        {
            var fiscal = new VagaAptoParaCadastroNoSistema();
            ResultadoValidacao = fiscal.Validar(this);
            return ResultadoValidacao.IsValid;
        }
    }
}
