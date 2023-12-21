using Newtonsoft.Json;

namespace CSTPlaca.CrossCutting.Model
{


    public partial class ApiPlacaModel
    {
        [JsonProperty("MARCA")]
        public string Marca { get; set; }

        [JsonProperty("MODELO")]
        public string Modelo { get; set; }

        [JsonProperty("SUBMODELO")]
        public string Submodelo { get; set; }

        [JsonProperty("VERSAO")]
        public string Versao { get; set; }

        [JsonProperty("ano")]
        public long Ano { get; set; }

        [JsonProperty("anoModelo")]
        public long AnoModelo { get; set; }

        [JsonProperty("chassi")]
        public string Chassi { get; set; }

        [JsonProperty("codigoSituacao")]
        public long CodigoSituacao { get; set; }

        [JsonProperty("cor")]
        public string Cor { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("extra")]
        public Extra Extra { get; set; }

        [JsonProperty("fipe")]
        public Fipe Fipe { get; set; }

        [JsonProperty("listamodelo")]
        public List<string> Listamodelo { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("marca")]
        public string ApiPlacaModelMarca { get; set; }

        [JsonProperty("marcaModelo")]
        public string MarcaModelo { get; set; }

        [JsonProperty("mensagemRetorno")]
        public string MensagemRetorno { get; set; }

        [JsonProperty("modelo")]
        public string ApiPlacaModelModelo { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("origem")]
        public string Origem { get; set; }

        [JsonProperty("placa")]
        public string Placa { get; set; }

        [JsonProperty("placa_alternativa")]
        public string PlacaAlternativa { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }

    public partial class Extra
    {
        [JsonProperty("ano_fabricacao")]
        public long AnoFabricacao { get; set; }

        [JsonProperty("ano_modelo")]
        public long AnoModelo { get; set; }

        [JsonProperty("caixa_cambio")]
        public string CaixaCambio { get; set; }

        [JsonProperty("cap_maxima_tracao")]
        public long CapMaximaTracao { get; set; }

        [JsonProperty("carroceria")]
        public string Carroceria { get; set; }

        [JsonProperty("chassi")]
        public string Chassi { get; set; }

        [JsonProperty("cilindradas")]
        public long Cilindradas { get; set; }

        [JsonProperty("combustivel")]
        public string Combustivel { get; set; }

        [JsonProperty("di")]
        public long Di { get; set; }

        [JsonProperty("eixo_traseiro_dif")]
        public string EixoTraseiroDif { get; set; }

        [JsonProperty("eixos")]
        public long Eixos { get; set; }

        [JsonProperty("especie")]
        public string Especie { get; set; }

        [JsonProperty("faturado")]
        public string Faturado { get; set; }

        [JsonProperty("grupo")]
        public string Grupo { get; set; }

        [JsonProperty("limite_restricao_trib")]
        public string LimiteRestricaoTrib { get; set; }

        [JsonProperty("linha")]
        public long Linha { get; set; }

        [JsonProperty("media_preco")]
        public object MediaPreco { get; set; }

        [JsonProperty("modelo")]
        public string Modelo { get; set; }

        [JsonProperty("motor")]
        public string Motor { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("nacionalidade")]
        public string Nacionalidade { get; set; }

        [JsonProperty("peso_bruto_total")]
        public long PesoBrutoTotal { get; set; }

        [JsonProperty("placa")]
        public string Placa { get; set; }

        [JsonProperty("placa_modelo_antigo")]
        public string PlacaModeloAntigo { get; set; }

        [JsonProperty("placa_modelo_novo")]
        public string PlacaModeloNovo { get; set; }

        [JsonProperty("quantidade_passageiro")]
        public long QuantidadePassageiro { get; set; }

        [JsonProperty("registro_di")]
        public string RegistroDi { get; set; }

        [JsonProperty("renavam")]
        public object Renavam { get; set; }

        [JsonProperty("restricao_1")]
        public string Restricao1 { get; set; }

        [JsonProperty("restricao_2")]
        public string Restricao2 { get; set; }

        [JsonProperty("restricao_3")]
        public string Restricao3 { get; set; }

        [JsonProperty("restricao_4")]
        public string Restricao4 { get; set; }

        [JsonProperty("s.especie")]
        public string SEspecie { get; set; }

        [JsonProperty("segmento")]
        public string Segmento { get; set; }

        [JsonProperty("situacao_chassi")]
        public string SituacaoChassi { get; set; }

        [JsonProperty("situacao_veiculo")]
        public string SituacaoVeiculo { get; set; }

        [JsonProperty("sub_segmento")]
        public string SubSegmento { get; set; }

        [JsonProperty("terceiro_eixo")]
        public string TerceiroEixo { get; set; }

        [JsonProperty("tipo_carroceria")]
        public string TipoCarroceria { get; set; }

        [JsonProperty("tipo_doc_faturado")]
        public string TipoDocFaturado { get; set; }

        [JsonProperty("tipo_doc_importadora")]
        public string TipoDocImportadora { get; set; }

        [JsonProperty("tipo_doc_prop")]
        public string TipoDocProp { get; set; }

        [JsonProperty("tipo_montagem")]
        public long TipoMontagem { get; set; }

        [JsonProperty("tipo_veiculo")]
        public string TipoVeiculo { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("uf_faturado")]
        public string UfFaturado { get; set; }

        [JsonProperty("uf_placa")]
        public string UfPlaca { get; set; }

        [JsonProperty("unidade_local_srf")]
        public string UnidadeLocalSrf { get; set; }
    }

    public partial class Fipe
    {
        [JsonProperty("dados")]
        public List<Dado> Dados { get; set; }
    }

    public partial class Dado
    {
        [JsonProperty("ano_modelo")]
        public long AnoModelo { get; set; }

        [JsonProperty("codigo_fipe")]
        public string CodigoFipe { get; set; }

        [JsonProperty("codigo_marca")]
        public long CodigoMarca { get; set; }

        [JsonProperty("codigo_modelo")]
        public long CodigoModelo { get; set; }

        [JsonProperty("combustivel")]
        public string Combustivel { get; set; }

        [JsonProperty("id_valor")]
        public long IdValor { get; set; }

        [JsonProperty("mes_referencia")]
        public string MesReferencia { get; set; }

        [JsonProperty("referencia_fipe")]
        public long ReferenciaFipe { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("sigla_combustivel")]
        public string SiglaCombustivel { get; set; }

        [JsonProperty("texto_marca")]
        public string TextoMarca { get; set; }

        [JsonProperty("texto_modelo")]
        public string TextoModelo { get; set; }

        [JsonProperty("texto_valor")]
        public string TextoValor { get; set; }

        [JsonProperty("tipo_modelo")]
        public long TipoModelo { get; set; }
    }
}
