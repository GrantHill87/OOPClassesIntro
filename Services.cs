using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassesIntro
{
    internal class Service //Pascal casing is used here whenever defining a new class, at least when it's a public one, where the first letter
    {                      //regarding the name of a class is always capitalized.
        public string Name { get; set; } //these variables being defined within the scope of the 'Service' class are also referred to as fields. The code listed on the left of the properties.
        public double Price { get; set; }//the notions written within the curled brackets are referred to as properties.
        public string Type { get; set; } //if we wanted to make a block of code with its own separate body, we could write a new method with its own set of fields and properties.
        public double Time { get; set; }
    }
}
