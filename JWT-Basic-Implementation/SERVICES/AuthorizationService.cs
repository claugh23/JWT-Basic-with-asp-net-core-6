using JWT_Basic_Implementation.DTO;
using JWT_Basic_Implementation.Security;

namespace JWT_Basic_Implementation.SERVICES;

public class AuthorizationService
{
    private readonly string fake_email = "user@gmail.com";
    private readonly string fake_password = "admin123";
    private jwt_TokenGenerator jwtGenerator = new jwt_TokenGenerator();
    
    public string GetUserAuthentication(UserDTO credentials)
    { 
        
        
        if (credentials.email == fake_email && credentials.password == fake_password)
        {
            return jwtGenerator.GenerateToken();
        }
        else
        {
            return "user or password incorrect";
        }
    }
}