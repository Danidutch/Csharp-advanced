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

            protected float Volume = 0;

            public void SetVolume(float val)
            {
                Volume =val;
            }
            public float GetVolume()
            {
                return Volume;
            }
        }
    


        class Rect : Shape
        {



            static void Main(string[] args)
            {

                Shape a = new Shape();
                a.SetVolume(2.3f);
                Rect b = new Rect();
                b.SetVolume(5.9f);

                Console.WriteLine("Child of protected class. Volume: " + b.Volume);
               Console.WriteLine("a Volume: " + a.GetVolume());
               Console.ReadLine();
            }
        }
    }
}
    

