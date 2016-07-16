using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// had some problem not fixes yet
    /// </summary>


    public class Racer
    {
        private string name;
        public string address;
        public int id;


        public Racer(string name, string address, int id)
        {
            this.name = name;
            this.address = address;
            this.id = id;

        }

    }
    
    
    class RacerGenaric
    {

        static void notRealMain()
        {
            
            List<Racer> racers = new List<Racer>();
            racers.Add(new Racer("fsdsd","Hy",15));
            racers.Add(new Racer("sdgdfvb", "grsgsv", 15));
            racers.Add(new Racer("fsdsgvfsdsd", "Hy", 18));

            Lookup<int, Racer> lookup = (Lookup<int, Racer>)racers.ToLookup(r => r.id); /// need public access of that veriable 

            foreach (Racer item in lookup[15])
            {
                Console.WriteLine(item);
               
            }
            Console.ReadLine();
        }
    }
}
