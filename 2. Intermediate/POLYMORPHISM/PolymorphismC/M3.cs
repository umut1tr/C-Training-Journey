using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class M3:Bmw
    {
        public M3(string model, int horsePower, string colour) : base(colour, horsePower, model)
        {
            this.Model = model;
        }

        public override void Repair()
        {
            base.Repair();
        }

    }
}
