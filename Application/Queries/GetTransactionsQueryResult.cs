namespace Application.Queries;

public record Transaction(int Id, double Amount, string Brand);

public record GetTransactionsQueryResult(IReadOnlyCollection<Transaction> Transactions);