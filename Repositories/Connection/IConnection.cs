using System.Data;

namespace OnlineMarket.Repositories.Connection
{
    public interface IConnection
    {
        IDbConnection OpenConnection();
    }
}
