using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Servico 
  {
    public int ServicoID { get; set; }
    public string? Descricao {get; set;}
    public double? Valor {get; set;}

    public ICollection<Reserva> Reservas {get; }
  }
}