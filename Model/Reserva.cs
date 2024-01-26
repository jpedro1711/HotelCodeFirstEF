using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Reserva 
  {
    public int ReservaID { get; set; }
    public DateTime? DataCheckin {get; set;}
    public DateTime? DataCheckout {get; set;}
    public int FuncionarioID {get; set;}
    public Funcionario? Funcionario {get; set;}
    public int ClienteID {get; set;}
    public Cliente? Cliente {get; set;}
    public Filial? Filial {get; set;}
    public ICollection<ItemConsumivel> ItemsConsumidos {get; }
    public ICollection<Servico> Servicos {get; }
    public ICollection<Consumo> Consumos {get; }
  }
}