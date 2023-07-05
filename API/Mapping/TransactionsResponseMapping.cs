using Application.Queries;
using Mapster;
using SimpleFin.Responses;

namespace SimpleFin.Mapping;

public class TransactionsResponseMapping: IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Transaction, TransactionsResponse.Transaction>()
            .Map(dest => dest.TotalAmount, src => src.Amount)
            .Map(dest => dest.BrandName, src => src.Brand);
        
        // config.NewConfig<GetTransactionsQueryResult, TransactionsResponse>();
    }
}