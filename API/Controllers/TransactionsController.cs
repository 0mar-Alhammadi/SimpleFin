using System.Text.Json;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleFin.Requests;

namespace SimpleFin.Controllers;
[ApiController]
[Route("v1/me/[controller]")]
public class TransactionsController : Controller
{
    private readonly IMediator _mediator;

    public TransactionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var query = new GetTransactionsQuery();

        var result = await _mediator.Send(query);
        
        return Ok(result);
    }
    
    [HttpPost]
    public IActionResult Create([FromBody]CreateTransactionRequest request)
    {
        
        return Ok(request);
    }
}