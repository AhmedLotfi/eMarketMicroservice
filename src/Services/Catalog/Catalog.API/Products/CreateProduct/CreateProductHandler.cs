using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;

internal class CreateProductCommandHandler :ICommandHandler<CreateProductCommand, CreateProductResult>
{
       public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken ct)
       {
              Product product = new ()
              {
                     Name = command.Name,
                     Category = command.Category,
                     Price = command.Price,
                     Description = command.Description,
                     ImagePath = command.ImagePath,
              };

              return new(Guid.NewGuid());
       }
}

public record CreateProductCommand(string Name, List<string> Category, string Description,string ImagePath, decimal Price)
       :ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);