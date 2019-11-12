using System;
using System.Collections.Generic;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace CandyMarket.Api.Repositories
{
    public class CandyRepository : ICandyRepository

    {
        string _connectionString = "Server=localhost;Database=SlackChannel;Trusted_Connection=True;";
        public IEnumerable<Candy> GetAllCandy()
        {
            using (var db = new SqlConnection(_connectionString))
            {
              

                var candies = db.Query<Candy>("Select * From Members");

                return candies.ToList();
            }
            
        }

        public bool AddCandy(AddCandyDto newCandy)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO [dbo].[Members]
                                        ([fullname]
                                         ,[displayname]
                                          ,[email]
                                        ,[userid])
                           VALUES
                                        (@fullname
                                        ,@userid)";

                return db.Execute(sql, newCandy) == 1;

            }
            //throw new NotImplementedException();
        }

        public bool EatCandy(candyIdToDelete)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"delete
                            from Members
                            where [Id] = @candyIdToDelete";

                return db.Execute(sql, new { candyIdToDelete }) == 1;
            }
            //throw new NotImplementedException();
        }
    }
}