public class Word
{
    private bool _isHidden;
    private string _content;
    public Word(string text)
    {
         _content = text;
         _isHidden = false;
    }

    public string GetDisplayText()
    {
        // returns the text of the word or else returns _____
        return ($"{_content}");
    }

    public void HideWord()
    {
        // set the _isHidden variable to true
    }

    public void ShowWord()
    {
        // set the _isHidden variable to false
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}