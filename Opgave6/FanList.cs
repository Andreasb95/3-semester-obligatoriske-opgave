using System;
using System.Collections.Generic;
using System.Text;
using FanLibrary;

namespace Opgave6
{
    public class FanList
    {
        public static List<FanOutput> datalist = new List<FanOutput>()
        {
            new FanOutput("Lokale 4", 23, 45),
            new FanOutput("Lokale 304", 23, 65),
            new FanOutput("Lokale 204", 23, 65)
        };

        public FanList()
        {
            
        }

        
    }
}
