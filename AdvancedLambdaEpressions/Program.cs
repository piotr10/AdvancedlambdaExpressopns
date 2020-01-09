using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLambdaEpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* INFORMACJE DODATKOWEE
             arguments => expression
             () => ... lamda expression bez argumentów
             x => ... z 1 argumentem
             (x,y,z) => ... więcej niż jeden argument

             PONIZEJ 5 PRZYKLADOW ZASOTOWANIA LAMBDA EXPRESSION
            */

            //1 pierwsza próba pokazania działania lambda expression

            //Console.WriteLine(Square(5));

            /*
            //2 druga próba pokazania działania lambda expression / mnozenie tego samego argumentu

            // number => number * number
            Func<int, int> square = number => number * number; //podstawowa wersja lambda expression
            Console.WriteLine(square(5)); //wywołanie square z lamba expression i delegatem Func
            */

            /*
            //3 trzecia próba pokazania działania lambda expression / mnonzenie dwoch argumentow

            const int factor = 5;

            Func<int, int> multipler = n => n * factor;
            var result = multipler(10);
            Console.WriteLine(result); //result = 50
            */

            /*
            //Moja skrócona wersja punkltu nr 3
            
            const int factor = 5;

            Func<int, int> square = n => n * factor;
            Console.WriteLine(square(10));
            */

            /*
            //4 czwarta próba pokazania działania lambda expression z uzyciem klasy BookRepository i klasy Book

            //kod w którym pokażemy książki tańsze niż 10$

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheapreThan10Dollars); // FindAll(Predicate<Book>)  / predicate - orzec, twierdzić u nas np. twierdzimy, ze w Metodzie IsCheapreThan10Dollars, Price jest mniejsze niż 10$
            foreach (var book in cheapBooks)
            {
                Console.WriteLine("Książka: " + book.Title + " Cena = " + book.Price);
            }
            */

            
             //5 piąta próba pokazania działania lambda expression z uzyciem klasy BookRepository i klasy Book
 
             //kod w którym pokażemy książki tańsze niż 10$
 
             var books = new BookRepository().GetBooks(); 
             var cheapBooks = books.FindAll(book => book.Price < 10); // tutaj zeby skrocic skladnie mozemy uzyc (b => b.Price < 10) zamiast (book => book.Price < 10)

             foreach (var book in cheapBooks)
             {
                 Console.WriteLine("Książka: " + book.Title + ", Cena = " + book.Price);
             }
             
        }
        /*
        //4 czwarta próba pokazania działania lambda expression z uzyciem klasy BookRepository i klasy Book
        
        static bool IsCheapreThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
       */

        /*
        //1 pierwsza próba pokazania działania lambda expression

         static int Square(int number)
         {
             return number * number;
         }
        */

    }
}
