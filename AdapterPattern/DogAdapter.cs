using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    /// </summary>
    public class DogAdapter : IPeople
    {
        private readonly IDog Adaptee;

        public DogAdapter(IDog adaptee)
        {
            Adaptee = adaptee;
        }
        public void Speak()
        {
            Adaptee.Bow();
        }

        public void Walk()
        {
            Adaptee.Crawl();
        }
    }
}
