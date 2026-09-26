using System;


public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        int visibleCount = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleCount++;
            }
        }

        if (IsCompletelyHidden())
        {
            Environment.Exit(0);
        }
        else
        {
            if (numberToHide < 0)
            {
                numberToHide = 0;
            }
            if (numberToHide == 0)
            {
                return;
            }
            if(numberToHide > _words.Count)
            {
                numberToHide = _words.Count;
            }
            if (numberToHide > visibleCount)
            {
                numberToHide = visibleCount;
            }
            while (hiddenCount < numberToHide)
            {
                int index = new Random().Next(_words.Count);
                if (!_words[index].IsHidden())
                {
                    _words[index].Hide();
                    hiddenCount++;
                    visibleCount--;
                }
            }
        }
        
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
             displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = words.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
}
