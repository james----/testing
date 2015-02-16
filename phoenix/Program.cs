using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace phoenix
{

    public class ActiviyDooer
    {

        public int repitition { get; set; }

        public ActiviyDooer()
        {
            repitition = 5;

        }


        public ActiviyDooer(int reps)
        {
            repitition = reps;

        }
        void DoIt()
        {
            var dog = new Poodle();
            dog.IsDone += dog_IsDone;
        
        }

        void dog_IsDone(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    
    class Dog
    {
        public string dtype { get; set; }

        public event EventHandler IsDone;

        public void Activity(string Title)
        {
            if (IsDone != null)
                IsDone(this, EventArgs.Empty);

        }


    }


    class Poodle : Dog
    {
        void x()
        {
            dtype = "test";

        }
    }


    class Program
    {
        public string testprop { get; set; }
        static void Main(string[] args)
        {
            var t = new ActiviyDooer(5);

            var t3 = new ActiviyDooer();

            var range = Enumerable.Range(2014-100, 85).Reverse();

            foreach (var item in range)
            {
                Console.WriteLine(item.ToString());
            }

            Debugger.Break();
            
        }
    }

}
