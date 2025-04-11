using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ConstantlyChangingSystem
{
    internal class Programe
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Interface());
        }
    }

    static class Run_System
    {
        public static void Run(ObjectCCS[][] objects, int num_of_iter = 0, int stop = 0)
        {
            if (objects == null)
            {
                throw new ArgumentNullException("Exemplars were not passed.");
            }    

            stop = Math.Abs(stop);
            num_of_iter++;

            foreach (ObjectCCS[] ob in objects)
            {
                if (ob.Length == 0)
                {
                    throw new Exception("Objects were not passed");
                }

                ObjectCCS[] ob_list = new ObjectCCS[ob.Length - 1];
                Array.Copy(ob, 1, ob_list, 0, ob_list.Length);
                ob[0].assigning_objects(ob_list);
            }

            for (int i = 0; i < num_of_iter || num_of_iter <= 0; i++)
            {
                Console.WriteLine("----------\nIteration " + i + "\n----------");
                foreach (ObjectCCS[] ob in objects)
                {
                    ob[0].print_values();

                    Console.WriteLine();

                    ob[0].main();
                }  

                foreach (ObjectCCS[] ob in objects)
                {
                    ob[0].end();
                }

                if (stop != 0 && i % stop == 0 && (i+1 < num_of_iter || num_of_iter <= 0))
                {
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\n----------\n   END  \n----------");
        }
    }

    abstract class Object_Base
    {       
        public enum Values_Type
        {
            x,
            speed
        }

        public decimal[,] values = new decimal[Enum.GetValues(typeof(Values_Type)).Length, 2];

        protected Object_Base[] objects;
    }

    abstract class ObjectCCS : Object_Base
    {
        protected ObjectCCS(decimal[] initial_values)
        {
            if (initial_values == null)
            {
                throw new ArgumentNullException("Initial values ​​were not passed.");
            } 
            else if (initial_values.Length < values.Length/2)
            {
                throw new Exception("Not all parameters were set.");
            }

            for (int i = 0; i < values.Length / 2; i++)
            {
                values[i, 0] = values[i, 1] = initial_values[i];
            }
        }
        public abstract void main();

        public virtual void assigning_objects(Object_Base[] list) 
        {
            objects = list;
        }
        
        public virtual void print_values()
        {
            Console.WriteLine('\n' + GetType().Name);
            if (Enum.GetValues(typeof(Values_Type)).Length > 0)
            {
                for (int i = 0; i < Enum.GetValues(typeof(Values_Type)).Length; i++)
                {
                    Console.WriteLine(((Values_Type)i).ToString() + ' ' + values[i, 0]);
                }
            }
            else
            {
                Console.WriteLine("Object has no parameters.");
            }
        }

        public virtual void end()
        {
            foreach (int i in Enum.GetValues(typeof(Values_Type)))
            {
                values[i, 1] = values[i, 0];
            }
        }
    }
}