using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bolg.App_Code
{
    public class FluentDB
    {
        public static IDbContext Fluent_DB()
        {
            return new DbContext().ConnectionStringName("mysqlconnection", new MySqlProvider());
        }
    }
}