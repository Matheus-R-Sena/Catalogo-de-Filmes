using ABC.DBEFE.Shared.Enums;
using ABC.DBEFE.Shared.Enums.Domain;

namespace ABC.DBEFE.Domain.Models
{
    public class Acao : BaseEntity<int>
    {
        public virtual eSimNao Ativo { get; set; }
        public virtual string Controller { get; set; }
        public virtual string Action { get; set; }
        public virtual string URL { get; set; }
        public virtual int Prioridade { get; set; }
        public virtual eEventosDeTurma EventoEnum { get; set; }
        public virtual string Pai { get; set; }
        public virtual int PrioridadeInterna { get; set; }
        public virtual eSimNao VisivelNoMenu { get; set; }
        public virtual eModulosDoSistema Sistema { get; set; }
        public virtual eSimNao UrlExterna { get; set; } = eSimNao.N;

        public virtual string RetornaNomeDeAgrupamento()
        {
            string agrupamento = Pai;
            if (string.IsNullOrEmpty(Pai))
            {
                agrupamento = Controller;
            }

            return agrupamento;
        }

        public virtual object ToJson()
        {
            return ToJson(this);
        }

        public static object ToJson(Acao acao)
        {
            return new
            {
                controller = acao.Controller,
                action = acao.Action,
                url = acao.URL,
                prioridade = acao.Prioridade,
                evento = acao.EventoEnum.ToString(),
                agrupamento = acao.Pai,
                prioridadeInterna = acao.PrioridadeInterna,
                visivelNoMenu = acao.VisivelNoMenu.ToDescription(),
                Sistema = acao.Sistema.ToString(),
                urlExterna = acao.UrlExterna.ToDescription()
            };
        }
    }
}
