using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace NREout.Models
{




    class Context : DbContext
    {



        //banco de dados
        public Context() : base("Data Source=10.74.3.136;Initial Catalog=DB.NRE;User ID=nre;Password=nre12345")
        {
            Database.SetInitializer<Context>(null);
        }


        //tabelas
        public DbSet<FuncionarioModel> DBFuncionario { get; set; }


    }





}
