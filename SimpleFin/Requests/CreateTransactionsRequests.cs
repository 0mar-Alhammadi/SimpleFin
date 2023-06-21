using Microsoft.AspNetCore.Mvc;
namespace SimpleFin.Requests;

public class CreateTransactionRequest
{
    [FromBody]
    public double Amount { get; init; }
    [FromBody]
    public string? Brand { get; init; }
}