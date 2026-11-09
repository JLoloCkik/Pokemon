namespace Pokemon;

public class PokemonEggyszeru {
    public int PokedexNumber { get; set; }
    public int SpAttack { get; set; }
    public int SpDefense { get; set; }
    public int Speed { get; set; }
    public string Type1 { get; set; } = string.Empty;
    public string Type2 { get; set; } = string.Empty;
    public double? WeightKg { get; set; }
    public int Generation { get; set; }
    public bool IsLegendary { get; set; }

    public PokemonEggyszeru(string lines) {
        string[] splitLines = lines.Split(',');
        PokedexNumber = int.Parse(splitLines[0]);
        SpAttack  = int.Parse(splitLines[1]);
        SpDefense = int.Parse(splitLines[2]);
        Speed = int.Parse(splitLines[3]);
        Type1 = splitLines[4] ?? string.Empty;
        Type2 = splitLines[5] ?? string.Empty;
        WeightKg = double.TryParse(splitLines[6], out double result) ? result : 0.0;
        Generation = int.Parse(splitLines[7]);
        IsLegendary = int.Parse(splitLines[8]) == 0;
    }
    
}