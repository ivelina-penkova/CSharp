﻿namespace BookStore.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Books;
    using UI;


    public class BookStoreEngine
    {
        private readonly List<Book> books;
        private decimal revenue;
        private readonly IRenderer renderer;
        private readonly IInputHandler inputHandler;

        public BookStoreEngine()
        {
            this.IsRunning = true;
            this.books = new List<Book>();
            this.revenue = 0;
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            while (this.IsRunning)
            {
                string command = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(command))
                {
                    continue;
                }

                string[] commandArgs = command.Split();

                string commandResult = this.ExecuteCommand(commandArgs);

                Console.WriteLine(commandResult);
            }

            Console.WriteLine("Total revenue: {0:F2}", this.revenue);
        }

        private string ExecuteCommand(string[] commandArgs)
        {
            switch (commandArgs[0])
            {
                case "add":
                    return this.ExecuteAddBookCommand(commandArgs);
                case "sell":
                    return this.ExecuteSellBookCommand(commandArgs);
                case "remove":
                    return this.ExecuteRemoveBookCommand(commandArgs);
                case "stop":
                    this.IsRunning = false;
                    return "Goodbye!";
                default:
                    return "Unknown command";
            }
        }

        private string ExecuteRemoveBookCommand(string[] commandArgs) {
            string title = commandArgs[1];

            Book bookToRemove = this.books.FirstOrDefault(book => book.Title == title);

            if (bookToRemove == null)
                return "Book does not exist";

            this.books.Remove(bookToRemove);
            return "Book removed";
        }

        private string ExecuteSellBookCommand(string[] commandArgs) {
            string title = commandArgs[1];

            Book bookToSell = this.books.FirstOrDefault(book => book.Title == title);

            if (bookToSell == null)
            {
                return "Book does not exist";
            }

            if (commandArgs[0] == "sell")
            {
                this.revenue += bookToSell.Price;
                return "Book sold";
            }
            return "Unsuccessful sale!";
        }


        private string ExecuteAddBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];
            string author = commandArgs[2];
            decimal price = decimal.Parse(commandArgs[3]);

            this.books.Add(new Book(title, author, price));

            return "Book added";
        }
    }
}
