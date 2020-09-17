using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace World_Felix_Informatica.DAL.Class
{
    public class DalBase : DbContext
    {
        public DalBase(DbContextOptions<DalBase> options): base(options){}
    }
}
