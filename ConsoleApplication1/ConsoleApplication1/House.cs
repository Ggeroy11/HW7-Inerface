using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class House
    {
        List<IPart> part = new List<IPart>();
        public House()
        {
            part.Add(new Basement());
            part.Add(new Wall());
            part.Add(new Wall());
            part.Add(new Wall());
            part.Add(new Wall());
            part.Add(new Door());
            part.Add(new Window());
            part.Add(new Window());
            part.Add(new Window());
            part.Add(new Window());
            part.Add(new Roof());
        }
       


    }
}
