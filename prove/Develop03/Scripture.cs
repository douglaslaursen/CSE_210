class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    
    public bool HideWords()
    {
        int hiddenCount = 0;
        int randomIndex;
        Random random = new Random();
        for(int i = 0; i < 3; i++)
        {
            randomIndex = random.Next(0, _words.Count());
            if (_words[randomIndex].IsHidden())
            {
                i--;
            }
            else
            {
                _words[randomIndex].HideWord();
                hiddenCount++;
            }

            if (_words.Count() - 3< hiddenCount)
            {
                foreach(Word word in _words)
                {
                    word.HideWord();
                    return true;
                }
            }
        }
        return false;
    }
    public void PrintText()
    {
        Console.WriteLine(_reference.GetReference());
        foreach(Word word in _words)
        {
            Console.Write($"{word.GetWordString()} ");
        }
    }

    public Scripture(List<Word> words, Reference reference)
    {
        _words = words;
        _reference = reference;
    }
}