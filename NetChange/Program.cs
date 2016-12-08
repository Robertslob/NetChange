using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChange
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ports = s.Split(' ');
            int ownPort = int.Parse(ports[0]);
            int[] connectedPorts = new int[ports.Length -1];
            for(int i = 0; i<ports.Length-1; i++)
            {
                connectedPorts[i] = int.Parse(ports[i + 1]);
                if (ownPort < connectedPorts[i])
                    ;//make socket 
            }

            
        }
    }
}
