namespace Application.Queries;

public record Transaction(double Amount, string Brand);

public record GetTransactionsQueryResult(IReadOnlyCollection<Transaction> Transactions);