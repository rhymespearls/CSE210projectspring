public class Prompt
{
    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("how ws your day");
    }

    public String GetRandomPrompt()
    {

        return "this is a prompt";

    }
}
