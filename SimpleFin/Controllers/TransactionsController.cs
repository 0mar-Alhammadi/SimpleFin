using Microsoft.AspNetCore.Mvc;
using SimpleFin.Requests;

namespace SimpleFin.Controllers;
[ApiController]
[Route("v1/me/[controller]")]
public class TransactionsController : Controller
{
    [HttpGet]
    //no need to add all when fetching all
    //[Route("all")]
    public IActionResult Index()
    {
        return NotFound();
    }
    
    [HttpPost]
    public IActionResult Create([FromBody]CreateTransactionRequest request)
    {
        
        return Ok(request);
    }
}