class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _scripture;

    List<string> _prompts = new List<string>
    {
        "How was your day? ",
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What was the hardest thing you overcame today? ",
    };

    List<string> _scriptures = new List<string>
    {
        "5: If any of you lack wisdome let him ask of God. - James 1:5",
        "7: Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you: \n8: For every one that asketh receiveth; and he that seeketh findeth; and to him that knocketh it shall be opened. - Matthew 7:7-8",
        "30: And thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind, and with all thy strength: this is the first commandment. \n31: And the second is like, namely this, Thou shalt love thy neighbour as thyself. There is none other commandment greater than these. - Mark 12:30-31",
        "16: For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. - John 3:16",
        "28: Come unto me, all ye that labour and are heavy laden, and I will give you rest. \n29: Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. \n30: For my yoke is easy, and my burden is light. - Matthew 11:28-30",
        "15: If ye love me, keep my commandments. - John 14:15",
        "27: And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them. - Ether 12:27",
        "11: And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.\n12: And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.\n13: Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me. - Alma 7:11-13",
        "12: And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall. - Helaman 5:12",
        "7: And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. - 1 Nephi 3:7",
        "48: I say unto you, that I know of myself that whatsoever I shall say unto you, concerning that which is to come, is true; and I say unto you, that I know that Jesus Christ shall come, yea, the Son, the Only Begotten of the Father, full of grace, and mercy, and truth. And behold, it is he that cometh to take away the sins of the world, yea, the sins of every man who steadfastly believeth on his name. - Alma 5:48"
    };

    public void DisplayScripture()
    {
        Random scripture = new Random();
        int idx = scripture.Next(_scriptures.Count);
        _scripture = _scriptures[idx];
        Console.WriteLine(_scripture);
    }

    public void CreateEntry()
    {
        Random rnd = new Random();
        int idx = rnd.Next(_prompts.Count);
        _prompt = _prompts[idx];
        _date = DateTime.Now.ToShortDateString();
        Console.Write(_prompt);
        _response = Console.ReadLine();
    }

    public void displayResponse()
    {
        Console.WriteLine(CreateFileSystemString());
    }

    public string CreateFileSystemString()
    {
        string outputString = $"\n{_date}: {_prompt}: \n{_response}";
        return outputString;
    }

}