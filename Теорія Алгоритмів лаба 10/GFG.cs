public class GFG
{
    private int V = 9;
    private int FindMinDistance(int[] distance, bool[] set)
    {
        int minValue = int.MaxValue, minValue_index = -1;
        for(int i=0;i<V;i++)
        {
            if (set[i] == false && distance[i] <= minValue)
            {
                minValue = distance[i];
                minValue_index = i;
            }
        }
        return minValue_index;
    }
    public void PrintGFG(int[] distance)
    {
        Console.WriteLine("Vertex \t\t Distance\n");
        for(int i =0;i<V;i++)
        {
            Console.WriteLine(i + "\t\t" + distance[i] + "\n");
        }
    }
    public void Algorithm_Deykstry(int[,]graph,int source)
    {
        int[] distance = new int[V];
        bool[] set = new bool[V];
        for(int i=0;i<V;i++)
        {
            distance[i] = int.MaxValue;
            set[i] = false;
        }
        distance[source] = 0;
        for (int i = 0; i < V - 1; i++)
        {
            int x = FindMinDistance(distance, set);
            set[x] = true;
            for (int j = 0; j < V; j++)
            {
                if (!set[j] && graph[x, j] != 0 && distance[x] != int.MaxValue
                    && distance[x] + graph[x, j] < distance[j])
                {
                    distance[j] = distance[x] = graph[x, j];
                }
            }
        }
        PrintGFG(distance);
    }
}