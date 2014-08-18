using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5R.Experiment.CI.Travis
{
    public class Feature
    {
        public string Name { get; private set; }

        public Feature(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name.ToLower();
        }
    }
}
