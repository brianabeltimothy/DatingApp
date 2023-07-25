using System.ComponentModel.DataAnnotations;

namespace DatingAppApi.Entities
{
  public class AppUser
    {
      [Key] // optional, to specify the primary key
        public int Id { get; set; } 

        public string UserName { get; set; }  
    }
}