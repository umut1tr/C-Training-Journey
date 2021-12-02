using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // CHILD CLASS
    class Radio : ElectricalDevice
    {
        
        public Radio(bool isOn, string brand):base(isOn,brand)
        {                       

        }

        
        //method to listen to the Radio
        public void ListenRadio()
        {
            //check if radio is on
            if (IsOn)
            {
                //listen to Radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
