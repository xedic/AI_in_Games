using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_in_Games
{
    class Dijkstra
    {


        public List<Vertex> lowLevelGraph = new List<Vertex>(){
            new Vertex(),
            new Vertex(),
        };

        public List<Vertex> clusterGraph = new List<Vertex>(){
            new Vertex(),
            new Vertex(),
        };

        public List<Edge> lowLevelEdges = new List<Edge>();

        public Dictionary<Vertex, Vertex> GraphSearch(List<Vertex> graph, Vertex from, Vertex to)
        {
            Queue<Vertex> frontier = new Queue<Vertex>();
            frontier.Enqueue(from);

            Dictionary<Vertex, int> dist = new Dictionary<Vertex, int>();
            dist.Add(from, 0);

            Dictionary<Vertex, Vertex> prev = new Dictionary<Vertex, Vertex>();
            prev.Add(from, null);


            foreach (Vertex v in graph)
            {
                if (v.Equals(from))
                {
                    dist.Add(v, int.MaxValue);
                    prev.Add(v, null);
                }
            }

            while (frontier.Count != 0)
            {
                Vertex temp = frontier.Dequeue();
                foreach (Edge e in temp.edges)
                {
                    int cost = e.cost + dist[temp];


                    if (e.to.Equals(to))
                    {
                        prev[temp] = e.to;
                        return prev;
                    }
                    if (cost < dist[e.to])
                    {
                        dist[temp] = cost;
                        prev[temp] = e.to;
                    }
                }
            }
            return null;

        }

        private List<Edge> CreateEdges()
        {
            List<Edge> returnList = new List<Edge>()
            {

            };
            return returnList;
        }

        public Vertex GetSpecificVertex(int id, Cluster cluster)
        {
            foreach (Vertex vertex in graph)
            {
                if (vertex.id == id && vertex.cluster == cluster)
                {
                    return vertex;
                }
            }
            return null;
        }

    }
}
