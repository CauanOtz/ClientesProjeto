using System;
using System.ComponentModel.DataAnnotations;

namespace MinhaAplicacao.Models;
public class Cliente
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; }
    public DateTime DataNascimento { get; set; }
    public string RG { get; set; }
    public string CPF { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Complemento { get; set; }
    public string UF { get; set; }
    public string CEP { get; set; }
    public string EstadoCivil { get; set; }
    public string NomePai { get; set; }
    public string NomeMae { get; set; }
}
