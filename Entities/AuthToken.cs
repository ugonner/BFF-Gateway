using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class AuthToken
{
    [Key]
    public int Id {get; set;}

    public string RefreshToken {get; set;}
    public string AccessToken {get; set;}
    public DateTime Expires {get; set;}

    public string Active {get; set;}

    [ForeignKey(nameof(User))]
    public int UserId {get; set;} 

    public User User {get; set;}
}