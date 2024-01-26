using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Quarto 
  {
    public int QuartoID { get; set; }
    public string? Tipo {get; set;}
    public bool? Adaptado {get; set;}
    public double? ValorDiaria {get; set;}
    public bool? ColchaoAdicional {get; set;}
    public int? Capacidade {get; set;}
    public int FilialID {get; set;}
    public Filial? Filial {get; set;}
  }
}