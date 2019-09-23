using System;
using System.Collections.Generic;

namespace genericsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag<char> scrabbleLetters = new Bag<char>();                //creating a new instance of the class bag to call the methods defined below, and created local char variable scrabbleLetters
            scrabbleLetters.PutItemIntoBag('q');                        //calling the method PutItemIntoBag from calss Bag that will add the letter q to the list Items
            scrabbleLetters.PutItemIntoBag('j');                        //calling the method PutItemIntoBag from calss Bag that will add the letter j to the list Items
            scrabbleLetters.PutItemIntoBag('z');                        //calling the method PutItemIntoBag from calss Bag that will add the letter z to the list Items
            scrabbleLetters.PutItemIntoBag('y');                        //calling the method PutItemIntoBag from calss Bag that will add the letter y to the list Items
            scrabbleLetters.PutItemIntoBag('x');                        //calling the method PutItemIntoBag from calss Bag that will add the letter x to the list Items
            char letterFromBag = scrabbleLetters.GetItemFromBag();      //creating local variable letterFromBag which is equal to the variable scrabbleLetters calling the method GetItemFromBag
            Console.WriteLine(letterFromBag);                           //returning the random letter from the line above
        }
    }

    class Bag<T>                                            //creating class bag and T is being used as a varaible placeholder
    {
        private List<T> items = new List<T>();              //creating a new list

        public void PutItemIntoBag(T item)                  //creating method PutItemIntoBag
        {
            items.Add(item);                                //the method PutItemIntoBag will add T item to the list items
        }

        public T GetItemFromBag()                           //creating method GetItemFromBag
        {
            Random rnd = new Random();                      //creating a new instance of the radnom method
            int randomIndex = rnd.Next(0, items.Count);     //creating an integer variable that is equal to 1 randmo number from the list items
            T randomItem = items[randomIndex];              //creting a variable randomItem that is equal to the items randomIndex
            items.RemoveAt(randomIndex);                    //for the list items calling the method RemoveAt which removes at the defined inde which is the random index from the line above
            return randomItem;                              //lastly you return the ranodm item
        }
    }
}