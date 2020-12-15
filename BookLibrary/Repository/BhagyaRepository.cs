using BookLibrary.Data;
using BookLibrary.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BhagyaRepository : IBhagyastoreRepoitory<Bhagyastorage>
    {
        private readonly BookStoreContext _context = null;
        public IConfiguration _Configuration { get; }
        public BhagyaRepository(BookStoreContext context, IConfiguration configuration)
        {
            _context = context;
            _Configuration = _Configuration;
        }
        public async Task<int> Insert(Bhagyastorage item)
        {
            double a = GetTotalAmount();
            var bs = new Bhagyastorage()
            {
                Itemname = item.Itemname,
                TotalQuantity = item.TotalQuantity,
                amount = item.amount,
                Tamount = item.Tamount,
                dm = item.dm,
                ym = item.ym,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };

            if (item.Tamount == a)
            {
                return bs.Id;
            }
            else
            {
                await _context.bhagyastorages.AddAsync(bs);
                await _context.SaveChangesAsync();
                return bs.Id;
            }
        }

        public double GetTotalAmount()
        {
            //int totalamountfromDB = (from soh in _context.bhagyastorages
            //                         select soh.Tamount).FirstOrDefault()
            double totalamountfromDB = (from soh in _context.bhagyastorages
                                        orderby soh.Tamount descending
                                        select soh.Tamount).FirstOrDefault();

            return totalamountfromDB;
            // return _context.bhagyastorages.OrderByDescending(totalamount => totalamount.Tamount).FirstOrDefault();
        }

        public async Task<List<Bhagyastorage>> GetAllUsage()
        {
            var usages = new List<Bhagyastorage>();
            // var allbooks = await _context.Books.ToListAsync();
            var allbooks = await (from iint in _context.bhagyastorages
                                  join n in _context.dropdownMonthlies on iint.dm equals n.Id
                                  join yr in _context.dropdownYearlies on iint.ym equals yr.Id

                                  select new
                                  {
                                      iint.Itemname,
                                      iint.TotalQuantity,
                                      iint.amount,
                                      iint.Tamount,
                                      iint.dm,
                                      iint.Id,
                                      iint.ym,
                                      iint.CreatedOn,
                                      n.Name,
                                  }

                                  ).Distinct().ToListAsync();

            if (allbooks?.Any() == true)
            {
                foreach (var book1 in allbooks)
                {
                    usages.Add(new Bhagyastorage()
                    {
                        Itemname = book1.Itemname,
                        TotalQuantity = book1.TotalQuantity,
                        amount = book1.amount,
                        Tamount = book1.Tamount,
                        dm = book1.dm,
                        Id = book1.Id,
                        ym = book1.ym,
                        CreatedOn = book1.CreatedOn,
                        month = book1.Name,
                        year = DateTime.Now.Year.ToString()
                    }); ;
                }
            }

            return usages;
        }

        //public double GetTotalAmount()
        //{
        //    Bhagyastorage bs = new Bhagyastorage();
        //    //int totalamountfromDB = (from soh in _context.bhagyastorages
        //    //                         select soh.Tamount).FirstOrDefault()
        //    // return _context.bhagyastorages.OrderByDescending(shipper => shipper.Id).FirstOrDefault();
        //    double totalamount = 0;
        //    SqlCommand cmd = new SqlCommand("usp_GetProductsByMonthly", myConnection.GetConnection());
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Tamount", bs.Tamount);
        //    SqlDataAdapter objda = new SqlDataAdapter(cmd);
        //    DataTable dtobj = new DataTable();
        //    objda.Fill(dtobj);
        //    if (dtobj.Rows.Count > 0)
        //    {
        //        totalamount = Convert.ToInt32(dtobj.Rows[0]["Tamount"].ToString());
        //    }

        //    return totalamount;
        //}
    }
}
