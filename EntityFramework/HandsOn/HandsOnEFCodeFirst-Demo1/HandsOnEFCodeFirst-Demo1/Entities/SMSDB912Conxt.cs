using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HandsOnEFCodeFirst_Demo1.Entities
{
    internal class SMSDB912Conxt:DbContext
    {
        //Configure the connectionstring using app.config file
        public SMSDB912Conxt():base("name=SMSDBConnection")
        {

        }
        //define the set
        public DbSet<Student> Students { get; set; }
    }
}
