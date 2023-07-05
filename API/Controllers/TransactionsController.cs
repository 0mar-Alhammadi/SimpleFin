using System.Text.Json;
using Application.Queries;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleFin.Requests;
using SimpleFin.Responses;

namespace SimpleFin.Controllers;
[ApiController]
[Route("v1/me/[controller]")]
public class TransactionsController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public TransactionsController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var query = new GetTransactionsQuery();

        var result = await _mediator.Send(query);

        var mappedResult = _mapper.Map<TransactionsResponse>(result);
        
        return Ok(mappedResult);
    }
    
    [HttpPost]
    public IActionResult Create([FromBody]CreateTransactionRequest request)
    {
        
        return Ok(request);
    }
}