using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Shoes: Clothes
    {
        string type;
        public override void ChooseType()
        {
            Console.WriteLine($"Оберiть: кросовки(0), черевики(1), туфлі(2)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                type = "черевики";
            }
            else if (choice == 2)
            {
                type = "туфлi";
            }
            else
            {
                type = "кросовки";
            }
        }
        public override void Wear()
        {
            if (type == null)
                Console.WriteLine("Ви вдягли взуття.");
            else 
                Console.WriteLine("Ви вдягли " +type);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Shoes sh = obj as Shoes;
            if (sh as Shoes == null)
                return false;

            return sh.type == this.type;
        }
        public override int GetHashCode()
        {
            int unitCode = 0;
            if (type == "черевики")
                unitCode = 1;
            else if (type == "туфлi")
                unitCode = 2;
            else if (type == "кросовки")
                unitCode = 3;
            return unitCode;
        }
        public override string ToString()
        {
            return type;
        }
    }
}
