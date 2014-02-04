namespace TwilightShards.libAstrogenesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    
    public class Galaxy
    {
        public string galName { get; set; }
        public double innerFormationRadius { get; set; }
        public double barOuterEdge { get; set; }
        public double outerFormationRadius { get; set; }
        public double maxStellarDensity { get; set; }


        public override string ToString()
        {
            return galName + " Galaxy";
        }
    }
}
