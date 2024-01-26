using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Cliente 
  {
    public int ClienteID { get; set; }
    public string? Nome {get; set;}
    public string? Email {get; set;}
    public int EnderecoID {get; set;}
    public Endereco? Endereco {get; set;}
  }
}