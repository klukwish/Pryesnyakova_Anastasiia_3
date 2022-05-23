using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
     class Jacket: Clothes
    {
        string type;
        public override void ChooseType()
        {
            Console.WriteLine($"Оберiть: без куртки (0), куртка тепла(1), куртка легка(2)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                type = "куртка тепла";
            }
            else if (choice == 2)
            {
                type = "куртка легка";
            }
            else
            {
                type = "без куртки";
            }
        }
        public override void Wear()
        {
            if (type == null)
                Console.WriteLine("Ви вдягли куртку.");
            else if (type == "без куртки")
                Console.WriteLine("Без куртки.");
            else if (type == "куртка тепла")
                Console.WriteLine("Ви вдягли теплу куртку.");
            else if (type == "куртка легка")
                Console.WriteLine("Ви вдягли легку куртку");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Jacket j = obj as Jacket; 
            if (j as Jacket == null)
                return false;

            return j.type == this.type;
        }
        public override int GetHashCode()
        {
            int unitCode = 1;
            if (type == "без куртки")
                unitCode = 0;
            else if (type == "куртка тепла")
                unitCode = 2;
            else if (type == "куртка легка")
                unitCode= 3;
            return unitCode;
        }
        public override string ToString()
        {
            return type;
        }
    }
}
