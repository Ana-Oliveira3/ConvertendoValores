//Exercício-01
string nome;
int idade;
string cidade;
string programacao;
string hobbie;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite sua cidade:");
cidade = Console.ReadLine();

Console.WriteLine("Digite sua área da programação favorita:");
programacao = Console.ReadLine();

Console.WriteLine("Digite seu hobbie favorito:");
hobbie = Console.ReadLine();

Console.WriteLine($"O seu nome é {nome}, você tem {idade} anos, você mora na cidade de {cidade}, sua área favorita da programação é {programacao} e seu hobbie é {hobbie}");


//Exercício-02
char letra;

Console.WriteLine("Digite uma letra:");
letra = Convert.ToChar(Console.ReadLine().ToUpper());

Console.WriteLine($"Você digitou a letra: {letra}");


//Exercício-03
double numeroum;
double numerodois;
int soma;

Console.WriteLine("Digite o primeiro número:");
numeroum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numerodois = Convert.ToDouble(Console.ReadLine());

soma = Convert.ToInt16(Convert.ToDouble(numeroum + numerodois));

Console.WriteLine($"O resultado da soma dos dois números é {soma}");