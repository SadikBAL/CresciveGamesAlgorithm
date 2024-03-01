using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CresciveGamesAlgorithm
{
    public  class Knot
    {
        private string KnotName;
        List<Knot> ChildKnots;
        public Knot(string Name)
        {
            KnotName = Name;
            ChildKnots = new List<Knot>();
        }
        public void AddKnot(Knot child)
        {
            ChildKnots.Add(child);
        }
        public void PrintGroup()
        {
            Console.WriteLine("---> Result for KnotName : " + KnotName + " <---");
            List<Knot> Test = new List<Knot>();
            GetUniqeChild(ref Test);
            foreach (Knot child in Test) 
            {
                Console.Write(child.KnotName.ToString() + " ");
            }
            Console.WriteLine("\n---------------------------------------");
        }
        public void GetUniqeChild(ref List<Knot> output)
        {
            if(!output.Contains(this))
            {
                output.Add(this);
                foreach (Knot child in ChildKnots)
                {
                    child.GetUniqeChild(ref output);
                }
            }
        }
        

    }
}
