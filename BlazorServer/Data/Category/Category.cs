using System.Security.Cryptography;

namespace BlazorServer.Data;

public record Category(string Name)
{
    public string Name { get; set; } = Name;
}