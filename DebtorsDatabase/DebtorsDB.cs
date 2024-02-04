using Microsoft.Data.Sqlite;
using System.Globalization;

namespace DebtorsDatabase;

public static class DebtorsDB
{
    private static readonly string _databaseName = "debtors.db";
    private static readonly SqliteConnection _connection;
    private static readonly SqliteCommand _command;

    static DebtorsDB()
    {
        _connection = new SqliteConnection($"Data source = {_databaseName}");
        _command = _connection.CreateCommand();
        _connection.Open();
        CreateTable();
    }
    private static void CreateTable()
    {
        _command.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS debtors(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                surname TEXT NOT NULL,
                name TEXT NOT NULL,
                debt REAL NOT NULL,
                address TEXT
                    );
            ";
        _command.ExecuteNonQuery();
    }

    public static void AddDebtor(Debtor debtor)
    {
        _command.CommandText = $"INSERT INTO debtors(surname,name,debt,address)" +
            $" VALUES('{debtor.Surname}','{debtor.Name}',{debtor.Debt.ToString().Replace(',','.')},'{debtor.Address}')";
        _command.ExecuteNonQuery();
    }

    public static IEnumerable<Debtor> GetAllDebtors()
    {
        _command.CommandText = $"SELECT * FROM debtors";
        using var reader = _command.ExecuteReader();
        while(reader.Read())
        {
            yield return new Debtor()
            {
                Id = reader.GetInt32(0),
                Surname = reader.GetString(1),
                Name = reader.GetString(2),
                Debt = reader.GetDouble(3),
                Address = reader[4] == DBNull.Value ? "" : reader.GetString(4) 
            };
        }
        reader.Close();

    }

    public static Debtor? GetDebtorById(int id)
    {
        _command.CommandText = $"SELECT * FROM debtors WHERE id={id}";
        using var reader= _command.ExecuteReader();
        while(reader.Read())
        {
            return new Debtor()
            {
                Id = reader.GetInt32(0),
                Surname = reader.GetString(1),
                Name = reader.GetString(2),
                Debt = reader.GetDouble(3),
                Address = reader[4] == DBNull.Value ? "" : reader.GetString(4) 

            };
        }
        reader.Close();
        return null;
    }
    
    public static void RemoveDebtor(Debtor debtor)
    {
        _command.CommandText = $"DELETE FROM debtors WHERE id={debtor.Id}";
        _command.ExecuteReader();
    }
    public static void UpdateDebtor(Debtor debtor)
    {
        _command.CommandText =
            @$"UPDATE debtors SET
                surname='{debtor.Surname}',
                name='{debtor.Name}',
                debt={debtor.Debt},
                address='{debtor.Address}'
             WHERE id={debtor.Id}";
        _command.ExecuteNonQuery();
    }   



}

