using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_in_Games
{
    class Vertex
    {
        public int id;
        public Cluster cluster;
        public List<Edge> edges = new List<Edge>();

        public Vertex()
        {

        }
    }
}
