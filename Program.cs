using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ConstantlyChangingSystem.Object_Base;

//Система состоит из объектов различных типов, каждую итерацию присваивающих значение своему полю "root" при помощи функции "main" на основе полей "stem" объектов других типов.
//Каждая функция "main" должна  использовать все поля класса типа "Object_Base" в количестве не меньше 1 и иметь максимально упрощенный вид.
//Количество объектов должно быть не меньше 2.
//Все объекты системы должны взаимодействовать напрямую или косвенно друг с другом.
//За 1 итерацию хотя бы 1 объект должен изменить свое поле "root", иначе система будет считаться статичной.

namespace ConstantlyChangingSystem
{
    internal class Programe
    {
        static void Main()
        {
            A a = new A(new decimal[2] { 0, 1 });
            A a1 = new A(new decimal[2] { 15, -1 });

            Run_System.Run(new ObjectCCS[][] { new ObjectCCS[] { a, a1 }, new ObjectCCS[] { a1, a } }, 1, 2);

            Console.ReadKey();
        }
    }

    static class Run_System
    {
        private static bool infinity;
        public static void Run(ObjectCCS[][] objects, int num_of_iter, int stop = 0)
        {
            infinity = num_of_iter < 0;

            foreach (ObjectCCS[] ob in objects)
            {
                ObjectCCS[] ob_list = new ObjectCCS[ob.Length - 1];
                Array.Copy(ob, 1, ob_list, 0, ob_list.Length);
                ob[0].assigning_objects(ob_list);
            }

            for (int i = 0; i < num_of_iter || infinity; i++)
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

                if (stop != 0 && (i+1) % stop == 0)
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
        protected ObjectCCS(decimal[] initiate_values)
        {
            for (int i = 0; i < values.Length/2; i++)
            {
                values[i, 0] = values[i, 1] = initiate_values[i];
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
            for (int i = 0; i < Enum.GetValues(typeof(Values_Type)).Length; i++)
            {
                Console.WriteLine(((Values_Type)i).ToString() + ' ' + values[i, 0]);
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

    class A : ObjectCCS
    {
        public A(decimal[] initiate_values) : base(initiate_values)
        {

        }
        public override void main()
        {
            decimal step = values[(int)Values_Type.speed, 1] - objects[0].values[(int)Values_Type.speed, 1];
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
            }
        }
    }
}