using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Data
{
    public List<Poznamka> Poznamky { get; set; } = new List<Poznamka>();

    public void PridatPoznamku(Poznamka poznamka)
    {
        Poznamky.Add(poznamka);
    }

    public void UpravitPoznamku(int index, Poznamka poznamka)
    {
        Poznamky[index] = poznamka;
    }

    public void SmazatPoznamku(int index)
    {
        Poznamky.RemoveAt(index);
    }

    public void UlozitData(string soubor)
    {
        string json = JsonSerializer.Serialize(Poznamky);
        File.WriteAllText(soubor, json);
    }

    public void NacistData(string soubor)
    {
        if (File.Exists(soubor))
        {
            string json = File.ReadAllText(soubor);
            Poznamky = JsonSerializer.Deserialize<List<Poznamka>>(json) ?? new List<Poznamka>();
        }
    }
}