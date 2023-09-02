using System;
using System.IO;
using System.Text.Json;
using ExtendedCharts;

class ExtendedCompiler
{
    List<Vanilla> Events = new List<Vanilla>();
    void CompileScript(string Directory, string Final)
    {
        string JSONString = "";

        if (Events.Count > 0)
            JSONString = JsonSerializer.Serialize(Events[0]);

        for (int i = 0; i < Events.Count; i++)
        {
            if (i == 0)
                continue;

            JSONString += "\n" + JsonSerializer.Serialize(Events[i]);

        }

        Console.WriteLine(JSONString);
    }


    public void AddEvent(Vanilla obj)
    {
        Events.Add(obj);
    }
}