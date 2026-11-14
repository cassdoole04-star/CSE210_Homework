using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplayText()
    {
        List<string> display = new List<string>();
        foreach (Word word in _words)
        {
            display.Add(word.GetText());
        }
        return string.Join(" ", display);
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> visible = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    visible.Add(word);
                }
            }

            if (visible.Count == 0)
            {
                break;
            }

            int index = _random.Next(visible.Count);
            visible[index].Hide();
        }
    }

    public void RevealRandomWord()
    {
        List<Word> hidden = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hidden.Add(word);
            }
        }

        if (hidden.Count > 0)
        {
            int index = _random.Next(hidden.Count);
            hidden[index].Show();
        }
    }

    public void RevealWord(string wordText)
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() && word.Matches(wordText))
            {
                word.Show();
            }
        }
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
}