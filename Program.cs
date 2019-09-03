using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Hello
{
    class Program
    {
        class Shape
        {

            private float Volume = 0;

            public void SetVolume(float val)
            {
                Volume =val;
            }
            public float GetVolume()
            {
                return Volume;
            }
        }
    


    
        static void Main(string[] args)
        {

            Shape a = new Shape();
            a.SetVolume(2.3f);
            Console.WriteLine("a Volume: " + a.GetVolume());
            Console.ReadLine();
        }
    }
}
    

