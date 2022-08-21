using System;
using System.Data;
using csharp_project.Models;
using Microsoft.Data.Sqlite;
using Dapper;
 namespace csharp_project.Models
 {
      public interface SnipRepo
    {
            List<Sniipss> GetSnip();
    
    }
        public class snipR 
        {
            private readonly IConfiguration _configuration;
            public  snipR(IConfiguration configuration)
            {
                    _configuration = configuration;

            }
             public List<Sniipss> GetSnip()
             {
                  using (IDbConnection connection = new
                SqliteConnection(_configuration.GetConnectionString("ConnectionString")))
                {
                        var query = @"SELECT t.Title, t.lang, t.code_snip, t.discript;";
                        var all_saved_snips = connection.Query<Sniipss>(query);
                      
                        
                        return all_saved_snips.ToList();
                }
             }
              
        }
       
        }
   

  
    
 

    