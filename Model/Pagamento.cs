using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Pagamento 
  {
    public int PagamentoID {get; set;}
    public bool? Pago {get; set;}
    public string? Metodo {get; set;}
    public int ReservaID {get; set;}
    public Reserva? Reserva {get; set;}
  }
}