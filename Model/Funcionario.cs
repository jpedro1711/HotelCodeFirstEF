using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelEF
{
  public class Funcionario 
  {
    public int FuncionarioID { get; set; }
    public string? Nome {get; set;}
    public int CargoID {get; set;}
    public Cargo? Cargo {get; set;}
    public Filial? Filial {get; set;}
  }
}