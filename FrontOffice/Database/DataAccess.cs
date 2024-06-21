using FrontOffice.Models;
using Microsoft.Data.SqlClient;

namespace FrontOffice.Database
{
    public class DataAccess
    {
        private readonly string _connectionString;

        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Job> GetJobs()
        {
            var jobs = new List<Job>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Jobs", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobs.Add(new Job
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            Description = (string)reader["Description"],
                            Status = (bool)reader["Status"],
                            DateLimit = (DateTime)reader["DateLimit"]
                        });
                    }
                }
            }
            return jobs;
        }
    }
}
