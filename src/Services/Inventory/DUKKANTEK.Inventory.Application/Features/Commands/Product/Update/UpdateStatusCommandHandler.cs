using DUKKANTEK.Inventory.Domain.Enums;

namespace DUKKANTEK.Inventory.Application.Features.Commands.Product.Update;
internal class UpdateStatusCommandHandler : IRequestHandler<UpdateStatusCommand, BasicResponse<int>>
{
    private readonly IProductRepository _productRepository;

    public UpdateStatusCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }
    public async Task<BasicResponse<int>> Handle(UpdateStatusCommand request, CancellationToken cancellationToken)
    {
        Products getProduct = await _productRepository.GetByIdAsync(request.ProductId);
        if (getProduct == null)
        {
            throw new NotFoundException(name: nameof(Products), request.ProductId);
        }
        getProduct.ProductStatus = (int)request.ProductStatus;

        await _productRepository.UpdateAsync(getProduct);

        return new BasicResponse<int> { Data = getProduct.Id, Success = true };
    }
}
