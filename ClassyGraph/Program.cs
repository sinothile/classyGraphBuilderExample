using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyGraph
{
    public class Program
    {
        static void Main(string[] args)
        {
            GraphCreator graphCreator = new GraphCreator(new SpecialGraphBuilder());
            graphCreator.CreateGraph();
            ClassyGraph cg = graphCreator.GetClassyGraph();
            Console.WriteLine(cg);
            Console.ReadKey();
        }
    }
}
