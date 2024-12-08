using System;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string NomeCompleto { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [Required, MaxLength(15)]
    public string RG { get; set; }

    [Required, MaxLength(14)]
    public string CPF { get; set; }

    [Required]
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Complemento { get; set; }
    public string UF { get; set; }
    public string CEP { get; set; }

    [Required]
    public string EstadoCivil { get; set; }

    public string NomePai { get; set; }
    public string NomeMae { get; set; }
}
