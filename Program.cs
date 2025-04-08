using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            A a = new A(1);
            B b = new B(1);
            C c = new C(0);

            Run_System.Run(new ObjectCCS[][] { new ObjectCCS[] { a, b }, new ObjectCCS[] { b, a }, new ObjectCCS[] { c, a, b } }, 10);

            Console.ReadKey();
        }
    }

    static class Run_System
    {
        private static bool infinity;
        public static void Run(ObjectCCS[][] objects, int num_of_iter)
        {
            foreach (ObjectCCS[] ob in objects)
            {
                ObjectCCS[] ob_list = new ObjectCCS[ob.Length - 1];
                Array.Copy(ob, 1, ob_list, 0, ob_list.Length);
                ob[0].assigning_values(ob_list);
            }

            if (num_of_iter <= -1)
            {
                num_of_iter = 1;
                infinity = true;
            }

            for (int i = 0; i < num_of_iter; i++)
            {
                foreach (ObjectCCS[] ob in objects)
                {
                    ob[0].main();
                    Console.WriteLine(ob[0].root);
                }
                Console.WriteLine();

                foreach (ObjectCCS[] ob in objects)
                {
                    ob[0].end();
                }

                if (infinity)
                {
                    i--;
                }
            }
        }
    }

    abstract class Object_Base
    {
        public double stem { get; protected set; }
    }

    abstract class ObjectCCS : Object_Base
    {
        public abstract double root { get; protected set; }
        protected ObjectCCS(double begin_value)
        {
            stem = root = begin_value;
        }
        public abstract void main();

        public abstract void assigning_values(Object_Base[] list);

        public void end()
        {
            stem = root;
        }
    }

    class A : ObjectCCS
    {
        private Object_Base b;
        public A(double begin_value) : base(begin_value)
        {
        }
        public override double root { get; protected set; }
        public override void main()
        {
            root = b.stem;
        }

        public override void assigning_values(Object_Base[] list)
        {
            b = list[0];
        }
    }

    class B : ObjectCCS
    {
        private Object_Base a;
        public B(double begin_value) : base(begin_value)
        {
        }
        public override double root { get; protected set; }
        public override void main()
        {
            root = (a.stem - 1) * -1;
        }
        public override void assigning_values(Object_Base[] list)
        {
            a = list[0];
        }
    }

    class C : ObjectCCS
    {
        private Object_Base a;
        private Object_Base b;

        public C(double begin_value) : base(begin_value)
        {
        }
        public override double root { get; protected set; }
        public override void main()
        {
            root = a.stem + b.stem;
        }
        public override void assigning_values(Object_Base[] list)
        {
            a = list[0];
            b = list[1];
        }
    }
}