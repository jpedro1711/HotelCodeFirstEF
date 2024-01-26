using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HotelEF
{
  public class ConsumoReserva 
  {
    public int? Quantidade {get; set;}
    public bool? ServicoQuarto {get; set;}

    public int ReservaID { get; set; }
    [ForeignKey("ReservaID")]
    public Reserva Reserva  {get; set;}

    public int ConsumoID {get; set;}
    [ForeignKey("ConsumoID")]
    public Consumo Consumo {get; set;}
    
  }
}