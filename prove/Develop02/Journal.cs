using System.Globalization;
using System.IO;

// Class Name	                Journal	                                Entry	                    Prompt
// class methods	    _entriesList : list<Entry>	            _response : string	            _prompt : string
// 		                _date : DateTime	                    _entry : string                 _promptList : list<string> 
//                      	                                    _date : string
//          
// class functions	    SaveEntry(): void	                    ToString(): string	            GeneratePrompt(): string
// 	                    SaveJournal(string username): void		ToFile(): string
// 	                    LoadJournal(string username): Entry		
// 	                    ToString(): string		
public class Journal
{
    public List<Entry> _entriesList = new List<Entry>();
    public DateTime _date;

    public void SaveEntry(Entry entry)
    {
        _entriesList.Add(entry);
    }
    
    public void SaveJournal(string username)
    {
        string filename = $"{username}.csv";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Date, Prompt, Response");
            foreach(Entry entry in _entriesList)
            {
                outputFile.WriteLine($"{entry.ToFile()}");
            }
        }
    }

    public void LoadJournal(string username)
    {
        string filename = $"{username}.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entriesList = [];

        foreach (string rawLine in lines)
        {
            if(rawLine != "Date, Prompt, Response")
            {
                string line = rawLine.Substring(1, rawLine.Length - 2);

                string[] parts = line.Split("\",\"");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry();
                entry._date = date;
                entry._prompt._prompt = prompt;
                entry._response = response;

                entry.FromCSV();

                this.SaveEntry(entry);
            }
        }
    }

    public override string ToString()
    {
        string rvalue = "";

        foreach(Entry entry in _entriesList)
        {
            rvalue += $"{entry}\n";
        }

        return rvalue;
    }
}