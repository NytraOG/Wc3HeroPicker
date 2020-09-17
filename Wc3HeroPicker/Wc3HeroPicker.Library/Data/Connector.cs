using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Wc3HeroPicker.Library.Entities;

namespace Wc3HeroPicker.Library.Data
{
    public class Connector
    {
        private readonly string connectionString;

        public Connector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public async Task<List<Hero>> GetAll()
        {
            var heros = new List<Hero>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                var query = "Select * from Hero";

                var result = await connection.QueryAsync<Hero>(query, new DynamicParameters())
                                             .ConfigureAwait(false);

                heros.AddRange(result.ToList());
            }

            return heros;
        }

        public async Task<Hero> GetHeroByName(string name)
        {
            Hero result;

            using (var connection = new SQLiteConnection(connectionString))
            {
                var query = $"SELECT * FROM Hero WHERE Name = '{name}'";

                var enumerable = await connection.QueryAsync<Hero>(query, new DynamicParameters())
                                                 .ConfigureAwait(false);

                result = enumerable.FirstOrDefault();
            }

            return result;
        }

        public async Task<Hero> GetHeroById(string id)
        {
            Hero result;

            using (var connection = new SQLiteConnection(connectionString))
            {
                var query = $"SELECT * FROM Hero WHERE Id = '{id}'";

                var enumerable = await connection.QueryAsync<Hero>(query, new DynamicParameters())
                                                 .ConfigureAwait(false);

                result = enumerable.FirstOrDefault();
            }

            return result;
        }

        public async Task InsertHero(string name)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                var heroExists = await GetHeroByName(name).ConfigureAwait(false) != null;

                if (heroExists)
                    throw new Exception($"Der Hero {name} existiert bereits");
            }
        }
    }
}