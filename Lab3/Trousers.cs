using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Trousers: Clothes
    {
        string type;
        public override void ChooseType()
        {
            Console.WriteLine($"Оберiть: брюки(0), джинси(1), спортивнi штани(2)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                type = "джинси";
            }
            else if (choice == 2)
            {
                type = "спортивнi штани";
            }
            else if (choice == 0)
            {
                type = "брюки";
            }
        }
        public override void Wear()
        {
            if (type == null)
                Console.WriteLine("Ви вдягли штани.");
            else 
                Console.WriteLine("Ви вдягли " +type);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Trousers t = obj as Trousers;
            if (t as Trousers == null)
                return false;

            return t.type == this.type;
        }
        public override int GetHashCode()
        {
            int unitCode = 0;
            if (type == "брюки")
                unitCode = 1;
            else if (type == "джинси")
                unitCode = 2;
            else if (type == "спортивні штани")
                unitCode = 3;
            return unitCode;
        }
        public override string ToString()
        {
            return type;
        }
    }
}
