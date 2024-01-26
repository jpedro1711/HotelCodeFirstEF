using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HotelEF
{
  public class Conta 
  {
    public int Quantidade {get; set;}

    public int ReservaID { get; set; }
    [ForeignKey("ReservaID")]
    public Reserva Reserva  {get; set;}

    public int ItemConsumivelID {get; set;}
    [ForeignKey("ItemConsumivelID")]
    public ItemConsumivel ItemConsumivel {get; set;}
    
  }
}