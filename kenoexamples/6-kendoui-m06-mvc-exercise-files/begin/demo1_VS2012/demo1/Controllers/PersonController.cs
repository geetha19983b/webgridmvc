using System.Collections.Generic;
using System.Web.Mvc;
using demo1.Models;
using demo1.ViewModels;

namespace demo1.Controllers {

    public class PersonController : Controller {

        public ActionResult Create() {
            CreatePerson viewModel = new CreatePerson {Person = new Person(), States = GetStates()};
            return View(viewModel);
        }

        private IList<State> GetStates() {
            IList<State> output = new List<State>();
            output.Add(new State {Id = 1, Abbreviation = "AL"});
            output.Add(new State {Id = 2, Abbreviation = "AK"});
            output.Add(new State {Id = 3, Abbreviation = "AZ"});
            output.Add(new State {Id = 4, Abbreviation = "AR"});
            output.Add(new State {Id = 5, Abbreviation = "CA"});
            output.Add(new State {Id = 6, Abbreviation = "CO"});
            return output;
        }
    }
}