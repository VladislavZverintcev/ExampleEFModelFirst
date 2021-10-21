using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEFModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ExampleModelContainer();
            var mark = new Mark { Name = "Toyota" };
            var model1 = new Model { Name = "Runx", CarType = "Hatchback" };
            var model2 = new Model { Name = "Camry", CarType = "Sedan" };
            mark.Model.Add(model1);
            mark.Model.Add(model2);
            context.Marks.Add(mark);
            context.SaveChanges();
        }
    }
}
