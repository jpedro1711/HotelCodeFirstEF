using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Endereco 
  {
    public int EnderecoID { get; set; }
    public string? Rua {get; set;}
    public string? Cidade {get; set;}
    public string? Bairro {get; set;}
    public string? Estado {get; set;}
    public string? CEP {get; set;}
    public int Numero {get; set;}
  }
}