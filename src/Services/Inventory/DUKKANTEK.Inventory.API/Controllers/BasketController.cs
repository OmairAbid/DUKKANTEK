
using System.Net;

namespace DUKKANTEK.Inventory.API.Controllers;
[Route("api/basket")]
[ApiController]
public class BasketController : ControllerBase
{
    private readonly ILogger<BasketController> _logger;
    private readonly IMediator _mediator;
    public BasketController(ILogger<BasketController> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult> Add(AddProductToBasketCommand request, CancellationToken cancellationToken)
    {

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
