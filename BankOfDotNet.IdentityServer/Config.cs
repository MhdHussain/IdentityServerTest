using System.Collections;
using System.Collections.Generic;
using IdentityServer4.Models;

public class Config
{
    public static IEnumerable<ApiScope> GetAllApiResources()
    {
        return new List<ApiScope>
        {
            new ApiScope("bank", "Customers API")
        };
    }

    public static IEnumerable<Client> GetClients()
    {
        return new List<Client>
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = {"bank"}
            }
        };
    }
}