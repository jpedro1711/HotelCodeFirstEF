using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Filial 
  {
    public int FilialID { get; set; }
    public string? Nome {get; set;}
    public int? QuartosSolteiro {get; set;}
    public int? QuartosCasal {get; set;}
    public int? QuartosFamilia {get; set;}
    public int? QuartosPresidencial {get; set;}
    public int? QtdEstrelas {get; set;}
    public int EnderecoID {get; set;}
    public Endereco? endereco {get; set;}
  }
}