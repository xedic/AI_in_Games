using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_in_Games
{
    class Edge
    {
        public Vertex from;
        public Vertex to;
        public int cost;
        
        public Edge(Vertex from, Vertex to, int cost)
        {
            this.from = from;
            this.to = to;
            this.cost = cost;
        }
    }
}
