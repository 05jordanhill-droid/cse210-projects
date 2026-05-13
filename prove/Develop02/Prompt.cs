using System.Globalization;

// Class Name	                Journal	                                Entry	                    Prompt
// class methods	    _jahEntriesList : list<Entry>	        _jahResponse : string	           _jahPrompt : string
// 		                _jahDate : DateTime	                    _jahEntry : string                 _jahPromptList : list<string> 
//                      	                                    _jahDate : string                  _random : Random
//          
// class functions	    SaveEntry(): void	                    ToString(): string	               GeneratePrompt(): string
// 	                    SaveJournal(string username): void		ToFile(): string
// 	                    LoadJournal(string username): Entry		ToCSV(): string
// 	                    ToString(): string	                    FromCSV(): void
public class Prompt
{
    public List<string> _jahPromptList = new List<string>()
    {
        "prompt 1",
        "prompt 2",
        "prompt 3",
        "prompt 4",
        "prompt 5",
    };
    public string _jahPrompt;
    public Random _random = new Random();

    public Prompt()
    {
        _jahPrompt = GeneratePrompt();
    }

    public string GeneratePrompt()
    {
        _jahPrompt = _jahPromptList[_random.Next(_jahPromptList.Count)];
        return _jahPrompt;
    }
}