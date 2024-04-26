namespace esudantes;

// Alunos Thiago Mihcel schmidt, Cristyan Claudino Van Haandel
class Program
{
	static void Main()
	{
		Estudante estudante1 = new Estudante
		{
			Nome = "Joao",
			DataDeNascimento = new DateTime(1398, 7, 05),
			Matricula = "12345",
			Curso = "Engenharia",
		};

		estudante1.AdicionarNota(1.5);
		estudante1.AdicionarNota(9.2);
		estudante1.AdicionarNota(3.9);

		Estudante estudante2 = new Estudante
		{
			Nome = "Maria",
			DataDeNascimento = new DateTime(1987, 1, 20),
			Matricula = "54321",
			Curso = "Medicina",
		};

		estudante2.AdicionarNota(9.1);
		estudante2.AdicionarNota(8.7);
		estudante2.AdicionarNota(7.8);

		Console.WriteLine("Estudante 1:");
		Console.WriteLine($"Nome: {estudante1.Nome}");
		Console.WriteLine($"Idade: {estudante1.CalcularIdade()}");
		Console.WriteLine($"Matricula: {estudante1.Matricula}");
		Console.WriteLine($"Curso: {estudante1.Curso}");
		Console.WriteLine($"Média das Notas: {estudante1.CalcularMediaNotas()}");

		Console.WriteLine("\nEstudante 2:");
		Console.WriteLine($"Nome: {estudante2.Nome}");
		Console.WriteLine($"Idade: {estudante2.CalcularIdade()}");
		Console.WriteLine($"Matricula: {estudante2.Matricula}");
		Console.WriteLine($"Curso: {estudante2.Curso}");
		Console.WriteLine($"Média das Notas: {estudante2.CalcularMediaNotas()}");
	}
}