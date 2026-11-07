using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;

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

    public void SaveToFile(string filename)
    {
        string[] lines = new string[_entries.Count];
        for (int i = 0; i < _entries.Count; i++)
        {
            Entry entry = _entries[i];
            lines[i] = $"{entry._date}|{entry._promptText}|{entry._entryText}";
        }
        File.WriteAllLines(filename, lines);
    }
    
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
        }
    }
}