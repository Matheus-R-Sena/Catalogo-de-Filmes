String Nome = "Explorador de Marte";
Char categoria = 'A';

bool MissaoAtiva = true;
byte PorcentagemBateria = 94;
short temperaturaExterna = -120;
int DistanciaPercorridaMetros = 225000000; 
long QuantidadeSinaisRecebidos = 7500000000L;
float GravidadeMarte = 3.711f;
double DistanciaEstimada = 1500000;
decimal OrcamentoMissao = 1250000.75m;
int SituacaoCod = 42;
String ObservacaoInicial = "";

Console.WriteLine("TELEMETRIA DA MISSÃO");
Console.WriteLine($" {Nome}");
Console.WriteLine($" {categoria}");
Console.WriteLine($" {MissaoAtiva}");
Console.WriteLine($" {PorcentagemBateria}");
Console.WriteLine($" {temperaturaExterna}");
Console.WriteLine($" {DistanciaPercorridaMetros}");
Console.WriteLine($" {QuantidadeSinaisRecebidos}");
Console.WriteLine($" {GravidadeMarte}");
Console.WriteLine($" {DistanciaEstimada}");
Console.WriteLine($" {OrcamentoMissao}");
Console.WriteLine($" {SituacaoCod}");
Console.WriteLine($" {ObservacaoInicial}");



/*

A escrita do tipo byte é 0b_0101_1110
e também não entendi as escritas:

byte porcentagemBateria = 0b_0101_1110;
int distanciaPercorridaMetros = 225_000_000;
long quantidadeSinaisRecebidos = 7_500_000_000L;
float gravidadeMarte = 3.711f;
double distanciaEstimada = 1.5e6;
decimal orcamentoMissao = 1_250_000.75m;
int situacaoCod = 0x2A;
string? observacaoInicial = default;
var quantidadeTripulantes = 5;

*/
