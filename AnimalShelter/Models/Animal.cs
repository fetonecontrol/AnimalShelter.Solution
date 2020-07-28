using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int Id { get; set; }
    public string Description { get; set; }

    public string Type { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }

    public string Breed { get; set; }

    public string Date { get; set; }

  }
}
