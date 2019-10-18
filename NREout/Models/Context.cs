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
      //  public Context() : base("Data Source=10.74.7.163;Initial Catalog=DB.NRE;User ID=nre;Password=nre12345")
        public Context() : base("Data Source =10.74.7.163; Initial Catalog = UserManager; User ID=user;Password=seed")
        //public Context() : base("Data Source =ESEED48RY8R; Initial Catalog = UserManager; Integrated Security = True;User ID=user;Password=seed")
        {
            Database.SetInitializer<Context>(null);
        }


        //tabelas
        public DbSet<FuncionarioModel> Usuario { get; set; }


    }





}
