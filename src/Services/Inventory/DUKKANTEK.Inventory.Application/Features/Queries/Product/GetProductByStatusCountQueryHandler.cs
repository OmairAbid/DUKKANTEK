using AutoMapper;
using DUKKANTEK.Inventory.Application.Contracts.Repositories;
using DUKKANTEK.Inventory.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Application.Features.Queries.Product;
internal class GetProductByStatusCountQueryHandler : IRequestHandler<GetProductByStatusCountQuery, BasicResponse<ProductStatusCountResponse>>
{
    private readonly IProductRepository _productRepository;

    public GetProductByStatusCountQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    public async Task<BasicResponse<ProductStatusCountResponse>> Handle(GetProductByStatusCountQuery request, CancellationToken cancellationToken)
    {
        var productByStatus = await _productRepository.GetProductsByStatusCount();
        ProductStatusCountResponse response = new();
        response.ProductStatus = productByStatus;

        return new BasicResponse<ProductStatusCountResponse>() { Data = response, Success = true };
    }
}
