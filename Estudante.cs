
public class Estudante : Pessoa
{
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public List<double> Notas { get; set; } = new List<double>();

    public void AdicionarNota(double nota)
    {
        Notas.Add(nota);
    }

    public double CalcularMediaNotas()
    {
        if (Notas.Count == 0)
        {
            return 0;
        }

        double sum = 0;
        foreach (double nota in Notas)
        {
            sum += nota;
        }

        return sum / Notas.Count;
    }
}