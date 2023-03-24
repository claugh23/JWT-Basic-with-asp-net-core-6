namespace JWT_Basic_Implementation.DTO;

public class UserDTO
{
   
    public UserDTO(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public string email { get; set; }
    public string password { get; set; }
}