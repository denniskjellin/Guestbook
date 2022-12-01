/*
    Guestbook application    

    Written by Dennis Kjellin / Mid Sweden University
*/


using guestbook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace guestbook
{

    class Program
    {
      static void Main(string[] args)
        {
            // Create instance of the class StorePost.
            StorePost storepost = new StorePost();
            int i = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = true; //show cursor
                Console.WriteLine("Guestbook\n\n");
                Console.WriteLine("1. Add new post");
                Console.WriteLine("2. Remove post\n");
                Console.WriteLine("X. Exit application\n");
               
                // Let i = 0, start loop from 0.
                i = 0;
                foreach(Post post in storepost.getPosts())
                {
                    Console.WriteLine("[" + i++ + "]" + post.Author + ": " + post.Content);
                }

                // Get input from the user, menu selection.
                int inp = (int)Console.ReadKey(true).Key;

                // Switch case for input selection
                switch (inp)
                {
                    case '1':
                        Console.WriteLine("Enter author name..");

                        string author = Console.ReadLine();

                        Post obj = new Post();

                        // Validation - if input is empty throw an error, else save in object
                        if (string.IsNullOrEmpty(author))
                        {
                            Console.WriteLine("Error, enter a 'Author name'!.\n Press any key to reload.");
                            Console.ReadKey();
                            break;
                        } else
                        {
                            // save to object if successfull
                            obj.Author = author;
                        }
                        Console.WriteLine("Whats on your mind?");

                        //get user input
                        string content = Console.ReadLine();

                        // Validation - if input is empty throw an error, else save in object.
                        if (string.IsNullOrEmpty(content))
                        {
                            Console.WriteLine("Error, post can't be empty! \n Press any ley to reload.");
                            Console.ReadKey();
                            break;
                        } else
                        {
                            // save to object if successfull
                            obj.Content = content;
                            // save object to the json file.
                        }
                        break;
                    case '2':
                        Console.WriteLine("Enter the post 'number' you want to delete..");

                        // get input to delete
                        string index = Console.ReadLine();
                        storepost.delPost(Convert.ToInt32(index));
                        break;
                    case 88:
                        Environment.Exit(0);
                        break;


                }

            }
        }
    }
}


