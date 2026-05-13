using System.Globalization;

// Class Name	                Journal	                                Entry	                    Prompt
// class methods	    _entriesList : list<Entry>	            _response : string	            _prompt : string
// 		                _date : DateTime	                    _entry : string                 _promptList : list<string> 
//                      	                                    _date : string                  _random : Random
//          
// class functions	    SaveEntry(): void	                    ToString(): string	            GeneratePrompt(): string
// 	                    SaveJournal(string username): void		ToFile(): string
// 	                    LoadJournal(string username): Entry		ToCSV(): string
// 	                    ToString(): string	                    FromCSV(): void
public class Prompt
{
    public List<string> _promptList = new List<string>()
    {
        "prompt 1",
        "prompt 2",
        "prompt 3",
        "prompt 4",
        "prompt 5",
    };
    public string _prompt;
    public Random _random = new Random();

    public Prompt()
    {
        _prompt = GeneratePrompt();
    }

    public string GeneratePrompt()
    {
        _prompt = _promptList[_random.Next(_promptList.Count)];
        return _prompt;
    }
}