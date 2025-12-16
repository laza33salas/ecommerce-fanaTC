using MediatR;

namespace Ecommerce.Application.Behaviors;

public class UnhandledExceptionBehavior<TRequest, TResponse>
                                        : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        throw new NotImplementedException(); 
    }
}