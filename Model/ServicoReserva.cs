using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HotelEF
{
  public class ServicoReserva 
  {
    public int Quantidade {get; set;}

    public int ReservaID { get; set; }
    [ForeignKey("ReservaID")]
    public Reserva Reserva  {get; set;}

    public int ServicoID {get; set;}
    [ForeignKey("ServicoID")]
    public Servico Servico {get; set;}
  }
}