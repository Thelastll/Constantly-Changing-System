using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.CodeDom.Compiler;

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
        private static ObjectCCS[][] objects;
        public static void Set(ObjectCCS[][] initial_objects)
        {
            objects = initial_objects;

            if (objects == null)
            {
                throw new ArgumentNullException("Exemplars were not passed.");
            }

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
        }

        public static void Run(int num_of_iter = 1, int stop = 0)
        {
            stop = Math.Abs(stop);

            for (int i = 0; i < num_of_iter; i++)
            {
                foreach (ObjectCCS[] ob in objects)
                {
                    ob[0].print_values();

                    Console.WriteLine();

                    ob[0].base_func();
                }

                foreach (ObjectCCS[] ob in objects)
                {
                    ob[0].end();
                }

                if (stop != 0 && i % stop == 0 && (i + 1 < num_of_iter || num_of_iter <= 0))
                {
                    
                }
            }
        }
    }
    public abstract class Object_Base
    {
        public static List<string> Values_Type = new List<string>();

        public decimal[,] values = new decimal[Values_Type.Count, 2];

        protected Object_Base[] objects;
    }

    public abstract class ObjectCCS : Object_Base
    {
        protected ObjectCCS(decimal[] initial_values)
        {
            if (initial_values == null)
            {
                throw new ArgumentNullException("Initial values ​​were not passed.");
            }
            else if (initial_values.Length < values.Length / 2)
            {
                throw new Exception("Not all parameters were set.");
            }

            for (int i = 0; i < values.Length / 2; i++)
            {
                values[i, 0] = values[i, 1] = initial_values[i];
            }
        }
        public abstract void base_func();

        public virtual void assigning_objects(Object_Base[] list)
        {
            objects = list;
        }

        public virtual void print_values()
        {
            Console.WriteLine('\n' + GetType().Name);
            if (Values_Type.Count > 0)
            {
                for (int i = 0; i < Values_Type.Count; i++)
                {
                    Console.WriteLine(Values_Type[i].ToString() + ' ' + values[i, 0]);
                }
            }
            else
            {
                Console.WriteLine("Object has no parameters.");
            }
        }

        public virtual void end()
        {
            for (int i = 0; i < Values_Type.Count; i++)
            {
                values[i, 1] = values[i, 0];
            }
        }
    }
    public class A : ObjectCCS
    {
        public A(decimal[] initial_values) : base(initial_values)
        {
        }
        public override void base_func()
        {
            Console.WriteLine(Values_Type[0]);
            /*decimal step = values[(int)Values_Type.speed, 1] - objects[0].values[(int)Values_Type.speed, 1];
            decimal distance = Math.Abs(values[(int)Values_Type.x, 1] - objects[0].values[(int)Values_Type.x, 1]);

            if (values[(int)Values_Type.speed, 1] < 0)
            {
                step *= -1;
            }

            if (distance < step)
            {
                if (step != 0)
                {
                    values[(int)Values_Type.x, 0] += distance / step * values[(int)Values_Type.speed, 1];
                }

                values[(int)Values_Type.speed, 0] += objects[0].values[(int)Values_Type.speed, 1];

            }
            else
            {

                values[(int)Values_Type.x, 0] += values[(int)Values_Type.speed, 1];
            }*/


        }
    }
}