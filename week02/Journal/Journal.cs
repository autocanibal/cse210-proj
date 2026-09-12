using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
        {
            output.WriteLine($"{entry._date}---{entry._promptText}---{entry._entryText}\n");
        }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        _entries.Clear();
        
        foreach (string line in lines)
        {
            if(line == "")
            {
                continue;
            }
            else
            {
                string[] parts = line.Split("---");

                Entry fileEntry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };

                _entries.Add(fileEntry);
            }
        }
    }
}