using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Consumo 
  {
    public int ConsumoID { get; set; }
    public string? NomeItem {get; set;}
    public double? Preco {get; set;}
    public ICollection<Reserva> Reservas {get; }
  }
}