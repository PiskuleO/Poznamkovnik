public class Poznamka
{
    public string Nazev { get; set; }
    public string Text { get; set; }

    public Poznamka(string nazev, string text)
    {
        Nazev = nazev;
        Text = text;
    }

    public override string ToString()
    {
        return Nazev; // Pro zobrazení v ListBoxu
    }
}