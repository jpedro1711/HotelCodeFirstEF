using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HotelEF
{
  public class ItemConsumivel 
  {
    public int ItemConsumivelID { get; set; }
    public string? Nome {get; set;}
    public double? Preco {get; set;}
    public ICollection<Reserva> Reservas {get; }
  }
}