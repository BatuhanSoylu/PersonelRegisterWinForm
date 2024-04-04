using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelRegisterWinForm
{
    public class personelregistercontext:DbContext
    {
        public DbSet<People> peoples {  get; set; }
            
    }
}
