namespace IndexiumUI.DataBase;
using MySql.Data.MySqlClient;

public class DataBaseWorker
{
    private const string ConnectionString = "server=localhost;user=root;database=IndexiumDB;port=3305;password=edcijbpol171war";
    private readonly MySqlConnection _connection = new(ConnectionString);

    public DataBaseWorker()
    {
        _connection.Open();
    }
    
    public void ReadDataFromDataBase(string sqlQuery)
    {
        var command = new MySqlCommand(sqlQuery, _connection);
        var reader = command.ExecuteReader();
        
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                // Console.WriteLine(reader.GetValues(0)); продумать логику
            }
        }

        reader.Close();
    }

    public void WriteDataToDataBase(string sqlQuery)
    {
        var command = new MySqlCommand(sqlQuery, _connection);
        command.ExecuteNonQuery();
    }

    public void Deconstruct()
    {
        _connection.Close();
    }
}