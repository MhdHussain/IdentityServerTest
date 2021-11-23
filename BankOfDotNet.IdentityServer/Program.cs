using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
    .AddDeveloperSigningCredential()
    .AddInMemoryApiResources(Config.GetAllApiResources())
    .AddInMemoryClients(Config.GetClients());

var app = builder.Build();


app.Run();