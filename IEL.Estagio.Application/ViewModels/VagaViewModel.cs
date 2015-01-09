using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IEL.Estagio.Application.ViewModels
{
    public class VagaViewModel
    {
        public VagaViewModel()
        {
            //VagaId = Guid.NewGuid();
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

        [Required(ErrorMessage = "Preencha o campo Habilitação")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
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

        public virtual EmpresaViewModel Empresa { get; set; }
    }
}