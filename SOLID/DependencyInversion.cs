using System;

public interface IDatabase
{
    public void SaveData(string data);
}

// Database class implementing the IDatabase interface
public class PostgresDatabase : IDatabase
{
    public void SaveData(string data)
    { 
        // Some save data logic specific for Postgres
    }
}

// Database class implementing the IDatabase interface
public class MYSQLDatabase : IDatabase
{
    public void SaveData(string data)
    {
        // Some save data logic specific for MYSQL
    }
}

public class DataProcessor
{
    private readonly IDatabase _database;

    // Depends on IDatabase
    public DataProcessor(IDatabase database)
    {
        _database = database;
    }

    public void ProcessData(string data) 
    { 
        _database.SaveData(data);
    }
}

/*
 * We have our interface representing a database with a SaveData method.
 * Our two databases are concrete implementations of the interface
 * providing specific implementations of the save data method for each specific type of database.
 * 
 * DataProcessor depends on the interface rather than a specific implementation, which means we are decoupling the high level modules form our low level module.
 */