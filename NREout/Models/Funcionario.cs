using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace NREout.Models
{
    public class Funcionario
    {

        public List<FuncionarioModel> listaFuncionarios = new List<FuncionarioModel>();
        public Funcionario()
        {


            listaFuncionarios.Add(new FuncionarioModel
            {
                id = 1,
                Nome = "Jose Carlos",
                //email_pessoal = "jsC@homtail.com",
                rg = 1234567890,
                cpf = 1234566780,
                telefone = "01020304",
                id_nre = 0,
                //municipio = 0,
                //cargo_funcao = 0,
                email = "jsC@seed.pr.gov.br"
            }); ; ;

            listaFuncionarios.Add(new FuncionarioModel
            {
                id = 2,
                Nome = "Ana Maria",
                //email_pessoal = "ana@homtail.com",
                rg = 1234567890,
                cpf = 1234566780,
                telefone = "01020304",
                id_nre = 0,
                //municipio = 0,
                //cargo_funcao = 0,
                email = "anamaria@seed.pr.gov.br"
            }); ;

            /*sql
			USE [DB.NRE]
			GO

			INSERT INTO [dbo].[DBFuncionario]
					   ([Nome]
					   ,[email_pessoal]
					   ,[rg]
					   ,[cpf]
					   ,[telefone_pessoal]
					   ,[nre]
					   ,[cargo_funcao]
					   ,[email_funcional]
					   ,[telefone_funcional]
					   ,[municipio])
				 VALUES
					   ('Ana Maria',
					   'anamariaC@homtail.com',
					   1234567890, 
					   1234566780, 
					   '01020304',
					   2,
					   3, 
					   'anamaria@seed.pr.gov.br', 
					   '04030201',
					   10)
			GO

*/

        }

        public void CriaFuncionario(FuncionarioModel funcionarioModelo)
        {
            Context context = new Context();

            context.Usuario.Add(funcionarioModelo);
            context.SaveChanges();
            listaFuncionarios.Add(funcionarioModelo);
        }

        public void EditarFuncionario(int idFuncionario)
        {
            foreach (FuncionarioModel _funcionario in listaFuncionarios)
            {
                if (_funcionario.id == idFuncionario)
                {

                    Context context = new Context();
                    var dep = context.Usuario.Where(d => d.id == idFuncionario).First();

                    context.Usuario.Remove(_funcionario);
                    context.SaveChanges();
                    listaFuncionarios.Add(_funcionario);

                    break;
                }
            }
        }
        public void Deletafuncionario(int idFuncionario)
        {
            foreach (FuncionarioModel _funcionario in listaFuncionarios)
            {
                if (_funcionario.id == idFuncionario)
                {
                    Context context = new Context();

                    var dep = context.Usuario.Where(d => d.id == idFuncionario).First();
                    try
                    {
                        context.Usuario.Remove(_funcionario);
                        context.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                    break;
                }
            }
        }


        public FuncionarioModel GetFuncionario(int idFuncionario)
        {
            FuncionarioModel _funcionarioModel = null;
            foreach (FuncionarioModel _funcionario in listaFuncionarios)
                if (_funcionario.id == idFuncionario)
                    _funcionarioModel = _funcionario;
            return _funcionarioModel;
        }
    }
}