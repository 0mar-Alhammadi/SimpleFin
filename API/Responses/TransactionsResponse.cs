using System.Text.Json.Serialization;

namespace SimpleFin.Responses;

public record TransactionsResponse(
    [property: JsonPropertyName("transactions")]
    IReadOnlyCollection<TransactionsResponse.Transaction> Transactions
)
{
    public record Transaction(
        [property: JsonPropertyName("amount")]
        double TotalAmount, 
        [property: JsonPropertyName("brand")]
        string BrandName);
}