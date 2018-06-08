using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyGraph
{
    public abstract class GraphBuilderBase 
    {
        private ClassyGraph _classyGraph;

        public ClassyGraph Graph
        {
            get
            {
                return _classyGraph;
            }
        }

        public void InitialiseGraph()
        {
            _classyGraph = new ClassyGraph();
        }

        public abstract void ApplySeries();
        public abstract void ApplyAppearance();
        public abstract void BuildGraphType();
    }
}
