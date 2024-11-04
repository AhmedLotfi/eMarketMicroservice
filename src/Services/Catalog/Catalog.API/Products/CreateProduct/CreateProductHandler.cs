using MediatR;

namespace Catalog.API.Products.CreateProduct;

internal class CreateProductCommandHandler :IRequestHandler<CreateProductCommand, CreateProductResult>
{
       public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken ct)
       {
              throw new NotImplementedException();
       }
}

public abstract record CreateProductCommand(string Name, List<string> Category, string Description,string ImagePath, decimal Price)
       :IRequest<CreateProductResult>;
public abstract record CreateProductResult(Guid Id);