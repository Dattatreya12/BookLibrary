using BookLibrary.CommonConnection;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{

    public class LanguageRepository : ILanguageRepository
    {
        public IConfiguration _Configuration { get; }
        private readonly BookStoreContext _context = null;
        public LanguageRepository(BookStoreContext context, IConfiguration configuration)
        {
            _context = context;
            _Configuration = configuration;
        }
        public async Task<List<LanguageModel>> GetLanguage()
        {
            return await _context.languages.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Name = x.Name,
                Descriptiom = x.Description
            }).ToListAsync();
        }

        public async Task<List<dropdownMonthly>> getmonths()
        {
            return await _context.dropdownMonthlies.Select(x => new dropdownMonthly()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }


        public async Task<List<DropdownYearly>> getyears()
        {
            return await _context.dropdownYearlies.Select(x => new DropdownYearly()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }


        public async Task<List<dropdownMonthly>> getsqlallmonths()
        {
            List<dropdownMonthly> sdm = new List<dropdownMonthly>();
            try
            {
                string connectionString = "Server=DATTA;Database=BookApp;User Id=sa;Password:12345;Trusted_Connection=True;MultipleActiveResultSets=true";
                //string connectionString = _Configuration["ConnectionStrings:Default"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from dropdownMonthlies", connection);
                    cmd.CommandType = CommandType.Text;
                    //await myConnection.GetConnection().OpenAsync();
                    connection.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (await sdr.ReadAsync())
                        {
                            sdm.Add(new dropdownMonthly
                            {
                                Id = Convert.ToInt32(sdr["Id"]),
                                Name = sdr["Name"].ToString(),
                            });
                        }
                    }
                    // await myConnection.GetConnection().CloseAsync();
                    connection.Close();
                    return sdm;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<List<dropdownMonthly>> getsqlmonths()
        {
            return await getsqlallmonths();
        }
    }
}
