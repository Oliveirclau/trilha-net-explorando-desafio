using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Cláudio", sobrenome: "Oliveira");
Pessoa p2 = new Pessoa(nome: "Marina", sobrenome: "Silvia");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150);

// Cria uma nova reserva com mais de 10 dias para aplicar desconto
Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe os dados da Reserva
Console.WriteLine("Reserva efetuada com sucesso!");
Console.WriteLine($"Tipo da suíte: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: R$ {reserva.CalcularValorDiaria():F2}");
