using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Shirt: Clothes
    {
        string type;
        public override void ChooseType()
        {
            Console.WriteLine($"Оберiть: сорочка(0), кофта(1), футболка(2)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                type = "кофта";
            }
            else if (choice == 2)
            {
                type = "футболка";
            }
            else
            {
                type = "сорочка";
            }
        }
        public override void Wear()
        {
            if (type == null || type == "сорочка")
                Console.WriteLine("Ви вдягли сорочку.");
            else if (type == "кофта")
                Console.WriteLine("Ви вдягли кофту.");
            else if (type == "футболка")
                Console.WriteLine("Ви вдягли футболку.");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Shirt s = obj as Shirt;
            if (s as Shirt == null)
                return false;

            return s.type == this.type;
        }
        public override int GetHashCode()
        {
            int unitCode = 0;
            if (type == "кофта")
                unitCode = 1;
            else if (type == "футболка")
                unitCode = 2;
            return unitCode;
        }
        public override string ToString()
        {
            return type;
        }
    }
}
