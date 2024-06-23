using System;

class Entry
{
    public string _Prompt ="";
    public string _Response ="";
    public DateTime _Date;

    public Entry(string prompt, string response, DateTime date)
    {
        _Prompt = prompt;
        _Response = response;
        _Date = date;
    }

    public override string ToString()
    {
        return $"Prompt: {_Prompt}\nResponse: {_Response}\nDate: {_Date}\n";
    }
}
