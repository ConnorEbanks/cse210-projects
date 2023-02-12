using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private string _words;

    public Scripture(Reference theReference, string text)
    {
        // Set the variables, including, break up the text into parts and for each one,
        // create a new word object and add it to the list.
        // Don't forget to create a new list (e.g., = new List<Word>();...)
        _reference = theReference; 
        _words = text;
    }

    public void HideWords(int number)
    {
        // Hides "number" words at random
    }

    public string GetDisplayText()
    {
        string display = ($"{_words}");
        return display;
    }

    public bool IsCompletelyHidden()
    {
        // figure out if all the words are hidden, if so, return true. If not, return false.
        return false;
    }
}