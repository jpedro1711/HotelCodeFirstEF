using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Telefone 
  {
    public int TelefoneID { get; set; }
    public string? Tipo {get; set;}
    public string? NumeroTelefone {get; set;}
    public int ClienteID {get; set;}
    public Cliente? Cliente {get; set;}
  }
}