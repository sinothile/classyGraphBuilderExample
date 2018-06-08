using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyGraph
{
    public class ClassyGraph
    {
        public List<double> PrimarySeries { get; set; }
        public List<double> SecondarySeries { get; set; }
        public bool ShowShadow { get; set; }
        public bool LargeGraphSize { get; set; }
        public double Offset { get; set; }
        public GraphType GraphType { get; set; }
        public GraphColourPackage ColourType { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Graph type: ").Append(GraphType).Append(Environment.NewLine)
                .Append("Colour settings: ").Append(ColourType).Append(Environment.NewLine)
                .Append("Show shadow: ").Append(ShowShadow).Append(Environment.NewLine)
                .Append("Is large: ").Append(LargeGraphSize).Append(Environment.NewLine)
                .Append("Offset: ").Append(Offset).Append(Environment.NewLine);
            sb.Append("Primary series: ");
            foreach (double d in PrimarySeries)
            {
                sb.Append(d).Append(", ");
            }
            sb.Append(Environment.NewLine).Append("Secondary series: ");
            foreach (double d in SecondarySeries)
            {
                sb.Append(d).Append(", ");
            }
            return sb.ToString();
        }
    }

    public enum GraphType
    {
        Bar
        , Line
        , Stack
        , Pie
    }

    public enum GraphColourPackage
    {
        Sad
        , Beautiful
        , Ugly
    }

}
