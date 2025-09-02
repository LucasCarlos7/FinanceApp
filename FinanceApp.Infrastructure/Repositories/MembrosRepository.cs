using Dapper;

using FinanceApp.Core.InputModels;
using FinanceApp.Core.Interfaces.Repositories;
using FinanceApp.Infrastructure.Context;

using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Infrastructure.Repositories;

public class MembrosRepository : IMembrosRepository
{
    private readonly FinanceAppDbContext _dbContext;

    public MembrosRepository(FinanceAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task InserirAsync(MembrosInputModel membros)
    {
        string sql =
            @"INSERT INTO Membros
                (NomeCompleto, DataNascimento, GrauParentesco)
            VALUES
                (@NomeCompleto, @DataNascimento, @GrauParentesco)";

        var parameters = new
        {
            NomeCompleto = membros.NomeCompleto,
            DataNascimento = membros.DataNascimento,
            GrauParentesco = (int)membros.GrauParentesco
        };

        await _dbContext.Database.GetDbConnection()
            .ExecuteAsync(sql, parameters);
    }
}
