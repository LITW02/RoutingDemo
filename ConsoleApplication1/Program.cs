using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumTest;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new EnumTestDataContext();
            var status = new Statuse();
            status.Status = OrderStatus.Delivered;
            ctx.Statuses.InsertOnSubmit(status);
            ctx.SubmitChanges();

        }
    }
}
