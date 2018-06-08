using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyGraph
{
    public class GraphBuilder : GraphBuilderBase
    {

        public override void BuildGraphType()
        {
            Graph.GraphType = GraphType.Line;
            Graph.Offset = 1.2;
        }

        public override void ApplyAppearance()
        {
            Graph.ColourType = GraphColourPackage.Sad;
            Graph.LargeGraphSize = false;
            Graph.ShowShadow = true;
        }

        public override void ApplySeries()
        {
            Graph.PrimarySeries = new List<double>() { 1, 2, 3, 4, 5 };
            Graph.SecondarySeries = new List<double>() { 4, 5, 6, 7, 8 };
        }
        //private ClassyGraph _classyGraph;

        //public ClassyGraph GetGraph()
        //{
        //    return _classyGraph;
        //}

        //private void BuildGraphType()
        //{
        //    _classyGraph.GraphType = GraphType.Line;
        //    _classyGraph.Offset = 1.2;
        //}

        //private void ApplyAppearance()
        //{
        //    _classyGraph.ColourType = GraphColourPackage.Sad;
        //    _classyGraph.LargeGraphSize = false;
        //    _classyGraph.ShowShadow = true;
        //}

        //private void ApplySeries()
        //{
        //    _classyGraph.PrimarySeries = new List<double>() { 1, 2, 3, 4, 5 };
        //    _classyGraph.SecondarySeries = new List<double>() { 4, 5, 6, 7, 8 };
        //}

        //private void InitialiseGraph()
        //{
        //    _classyGraph = new ClassyGraph();
        //}

        //public void CreateGraph()
        //{
        //    InitialiseGraph();
        //    ApplySeries();
        //    ApplyAppearance();
        //    BuildGraphType();
        //}
    }

    }
