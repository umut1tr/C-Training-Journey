using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //CHILD ClASS
    class TV : ElectricalDevice
    {


        public TV(bool isOn, string brand) : base(isOn, brand)
        {
            
        }

        
        //method to Watch TV
        public void WatchTV()
        {
            //check if TV is on
            if (IsOn)
            {
                //listen to TV
                Console.WriteLine("Watching TV");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
