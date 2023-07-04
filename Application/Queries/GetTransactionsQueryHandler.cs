using MediatR;

namespace Application.Queries;

public class GetTransactionsQueryHandler: IRequestHandler<GetTransactionsQuery, GetTransactionsQueryResult>
{
    public Task<GetTransactionsQueryResult> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
    {
        var transactions = new List<Transaction>{ new (10, "lulu") };
        var result = new GetTransactionsQueryResult(transactions);

        return Task.FromResult<GetTransactionsQueryResult>(result);
    }
}