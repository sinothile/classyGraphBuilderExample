using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyGraph
{
    public class SpecialGraphBuilder : GraphBuilderBase
    {
        public override void ApplySeries()
        {
            Graph.GraphType = GraphType.Bar;
            Graph.Offset = 1.0;
        }

        public override void ApplyAppearance()
        {
            Graph.ColourType = GraphColourPackage.Beautiful;
            Graph.LargeGraphSize = true;
            Graph.ShowShadow = true;
        }

        public override void BuildGraphType()
        {
            Graph.PrimarySeries = new List<double>() { 1, 2, 3, 8, 10 };
            Graph.SecondarySeries = new List<double>() { 4, 5, 9, 3, 4 };
        }
    }
}
