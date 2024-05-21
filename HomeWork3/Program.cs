namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Задача 1
            var libriary = new Library();

            libriary += new Book("Dune part 1", "F.Gerbert");
            libriary += new Book("Dune part 2", "F.Gerbert");

            Console.WriteLine("Книги в библиотеке:");
            libriary.Print();

            Console.WriteLine("Ищем книгу");
            Console.WriteLine("Dune part 1" + libriary.ContainsBook("Dune part 1"));
            Console.WriteLine("Удаляем книгу");
            libriary -= "Dune part 1";
            Console.WriteLine("Новый список книг");
            libriary.Print();
            Console.WriteLine("\n\n");

            //Задача 2

            Console.WriteLine("Матрица 1\n");
            Matrix m1 = new Matrix(5, 1, 10);
            m1.Print();
            
            Console.WriteLine("\nМатрица 2\n");
            Matrix m2 = new Matrix(5, 1, 10);
            m2.Print();
            Console.WriteLine("\nМатрица 1 + матрица 2:");
            (m1 + m2).Print();
            Console.WriteLine("\nМатрица 1 - матрица 2:");
            (m1 - m2).Print();
            Console.WriteLine("\nМатрица 1 * матрица 2:");
            (m1 * m2).Print();
            Console.Write("\nВведите целое положительное число -> ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nМатрица 1 * число " + num + ":");
            (m1 * num).Print();
            Console.WriteLine("\nМатрица 2 * число" + num + ":");
            (m2 * num).Print();
            if (m1 == m2) Console.WriteLine("\nМатрицы равны!\n");
            if (m1 != m2) Console.WriteLine("\nМатирицы не равны!\n");
            if (m1.Equals(m2)) Console.WriteLine("Матрицы имеют одинаковые элементы в равных индексах");
            else Console.WriteLine("Матрицы не имеют ни одного одинакового элемента в равных индексах");
        }




    }
    }
