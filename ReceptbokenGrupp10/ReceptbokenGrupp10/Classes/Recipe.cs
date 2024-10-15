using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptbokenGrupp10.Classes
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }


        public override string ToString() //overide .title toString
        {
            return Title;
        }
    }
}
