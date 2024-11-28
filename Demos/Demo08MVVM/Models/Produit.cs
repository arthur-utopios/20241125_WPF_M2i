using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08MVVM.Models
{
    public class Produit
    {
        private string _name;

        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => Name;

    }
}
