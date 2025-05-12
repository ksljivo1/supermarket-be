using System.ComponentModel.DataAnnotations.Schema;
using EnvironmentName = Microsoft.AspNetCore.Hosting.EnvironmentName;

namespace Test.Api.Models;

[Table("users")]
public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    
    public User() { } // parameterless constructor (needed by EF)

    public User(string name, string password, string email)
    {
        this.name = name;
        this.password = password;
        this.email = email;
    }
}