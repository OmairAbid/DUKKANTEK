

namespace DUKKANTEK.Inventory.Application.Features.Commands.Basket;
internal class AddProductToBasketCommandHandler : IRequestHandler<AddProductToBasketCommand, BasicResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IBasketRepository _basketRepository;

    public AddProductToBasketCommandHandler(IProductRepository productRepository,
        IBasketRepository basketRepository
        )
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        _basketRepository = basketRepository;
    }
    public async Task<BasicResponse> Handle(AddProductToBasketCommand request, CancellationToken cancellationToken)
    {
        Products getProduct = await _productRepository.GetByIdAsync(request.ProductId);
        if (getProduct == null || getProduct.ProductStatus == (int)ProductStatus.Damaged || getProduct.ProductStatus == (int)ProductStatus.Sold)
        {
            throw new NotFoundException(name: nameof(Products), request.ProductId);
        }

        Baskets basket = new()
        {
             BillingAddress = request.BillingAddress,
             ShippingAddress = request.ShippingAddress,
             ProductId= request.ProductId,
        };
        await _basketRepository.AddAsync(basket);

        getProduct.ProductStatus = (int)ProductStatus.Sold;
        await _productRepository.UpdateAsync(getProduct);

        return new BasicResponse { Success = true };
    }
}
