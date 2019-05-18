using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class PaymentDetailContext: DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options)
            :base(options)
        {
            //in options we have to pass information like:
                //DB provider like sql server, mySql
                //connection string for the DB
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
