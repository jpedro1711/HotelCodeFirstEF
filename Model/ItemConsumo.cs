using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class ItemConsumo 
  {
    public int ItemConsumoID { get; set; }
    public string? Nome {get; set;}
    public double? Preco {get; set;}
    public bool? ServicoQuarto {get; set;}
  }
}