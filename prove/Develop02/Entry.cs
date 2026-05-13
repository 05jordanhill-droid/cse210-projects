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
public class Entry
{
    public string _response;
    public Prompt _prompt = new Prompt();
    public string _date;

    public Entry()
    {
        _prompt.GeneratePrompt();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
    }

    public string ToFile()
    {
        string rvalue = $"\"{ToCSV(_date)}\",\"{ToCSV(_prompt._prompt)}\",\"{ToCSV(_response)}\"";
        return rvalue;
    }

    public string ToCSV(string element)
    {
        element = element.Replace("\"", "\"\"");

        return element;
    }

    public void FromCSV()
    {
        this._date =_date.Replace("\"\"", "\"");
        this._prompt._prompt = _prompt._prompt.Replace("\"\"", "\"");
        this._response =_response.Replace("\"\"", "\"");
    }

    public override string ToString()
    {
        string rvalue = $"Date: {_date} - Prompt: {_prompt._prompt}\n{_response}\n";
        return rvalue;
    }
}