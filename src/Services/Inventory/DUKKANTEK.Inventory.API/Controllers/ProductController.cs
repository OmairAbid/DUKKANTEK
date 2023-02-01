using DUKKANTEK.Inventory.Application.Features.Commands.Product.Update;
using DUKKANTEK.Inventory.Application.Features.Queries.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DUKKANTEK.Inventory.API.Controllers;
[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IMediator _mediator;
    public ProductController(ILogger<ProductController> logger,
        IMediator mediator)
	{
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet]
    [Route("get-product-status-count")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult> Get(CancellationToken cancellationToken)
    {
        GetProductByStatusCountQuery request = new();
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

    [HttpPatch("{id:int}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult> UpdateStatus(int id, UpdateStatusCommand request, CancellationToken cancellationToken)
    {
        
        request.ProductId = id;

        try
        {
            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }
        catch (Exception)
        {

            return NotFound();
        }
        
    }
}
