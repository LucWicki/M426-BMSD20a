using System;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {

        

        public string Determine(int number)
        {
            string FBQ = "1";
            int foo;
            int bar;
            int qix;
            foo = number % 3;
            bar = number % 5;
            qix = number % 7;
            if (foo == 0)
            {
                FBQ = "Foo";
            }
            else if(bar == 0)
            {
                FBQ= "Bar";
            }
            else if(qix == 0)
            {
                FBQ = "Qix";
            }
            
            return FBQ;
        }
    }
}