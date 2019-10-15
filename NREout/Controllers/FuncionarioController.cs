using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using NREout.Models;


namespace NREout.Controllers
{

    public class FuncionarioController : Controller
    {
        //
        // GET: / Home


        private static Funcionario _funcionarios = new Funcionario();



        [HttpGet]
        //lista funcionarios
        public ActionResult Index()
        {
            return View(_funcionarios.listaFuncionarios);
        }

        public ActionResult AdicionaFuncionario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaFuncionario(FuncionarioModel _funcionarioModel)
        {
            _funcionarios.CriaFuncionario(_funcionarioModel);
            //chamar  context
            return View();
        }




        [HttpPost]
        public RedirectToRouteResult EditarFuncionario(int id, FormCollection collection)
        {
            _funcionarios.EditarFuncionario(id);
            return RedirectToAction("EditarFuncionario");
            // return View();
        }


        public ActionResult Deletafuncionario(int id, FormCollection collection)   // ou RedirectToRouteResult?
        {
            _funcionarios.Deletafuncionario(id);
            return RedirectToAction("Index");
        }


        /*   REDIRECIONA PARA O DELETAFUNCIONARIO.CSHTML (BUGADO)

        public ViewResult DeletaFuncionario(int id)  //string id
        {
            return View(_funcionarios.GetFuncionario(id));

        }

        [HttpPost]
        public RedirectToRouteResult DeletaFuncionario(int id, FormCollection collection) //string id
        {
            _funcionarios.DeletarFuncionario(id);
            return RedirectToAction("Index");
        }
        */

    }
}

