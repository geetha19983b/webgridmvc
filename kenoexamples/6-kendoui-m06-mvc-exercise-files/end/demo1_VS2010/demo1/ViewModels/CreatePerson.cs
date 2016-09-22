using System.Collections.Generic;
using demo1.Models;

namespace demo1.ViewModels {

    public class CreatePerson {

        public Person Person { get; set; }
        public IList<State> States { get; set; }

    }
}