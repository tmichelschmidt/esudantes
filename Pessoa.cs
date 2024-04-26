using System;
using System.Collections.Generic;

public class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }

    public int CalcularIdade()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - DataDeNascimento.Year;
        if (DataDeNascimento.Date > today.AddYears(-age)) age--;
        return age;
    }
}