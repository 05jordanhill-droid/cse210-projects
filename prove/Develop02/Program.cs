// Exceeding the Requirements: 
// Asks for username rather than file name and saves the name to .csv
// Accounts for commas and quotation marks to properly display in the .csv file and display into Excel

using System;
using System.Net;

// Class Name	                Journal	                        Entry	                    Prompt
// class methods	    _entriesList : list<Entry>	    _response : string	            _prompt : string
// 		                _prompt : Prompt	            _promptList : list<string>  
//                      _date : DateTime	    
// 	                    _entry : string	    
// class functions	    SaveEntry(): void	            ToString(): string	            ToString(): string
// 	                    SaveJournal(): void		
// 	                    LoadJournal(): Entry		
// 	                    ToString(): string		

class Program
{
    static void Main(string[] args)
    {
        Journal jahJournal = new Journal();

        string jahMenu = "\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ";

        string jahChoice = "";

        while(jahChoice != "5")
        {
            Console.Write(jahMenu);
            jahChoice = Console.ReadLine();

            Console.WriteLine();

            if (jahChoice == "1")
            {
                Entry entry = new Entry();
                Console.Write($"{entry._prompt._prompt}\n>");
                entry._response = Console.ReadLine();

                jahJournal.SaveEntry(entry);
            }
            else if(jahChoice == "2")
            {
                Console.WriteLine(jahJournal);
            }
            else if (jahChoice == "3")
            {
                Console.WriteLine("What is your Username?");
                string username = Console.ReadLine();
                jahJournal.LoadJournal(username);
            }
            else if (jahChoice == "4")
            {
                Console.WriteLine("What is your Username?");
                string username = Console.ReadLine();
                jahJournal.SaveJournal(username);
            }
        }
    }
}