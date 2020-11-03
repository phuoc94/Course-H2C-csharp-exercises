using System.Runtime.InteropServices.WindowsRuntime;

namespace exercise_120
{
    public class Cube
    {
        private int edgeLength;
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }

        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }

        public override string ToString()
        {
            return $"The length of the edge is {edgeLength} and the volume {Volume()}";
        }
    }
}