namespace Pokemon;

public class PokemonOsszetett
{
    public PokemonOsszetett(string lines) {
        List<string> abilities;
        string[] parts;
        string[] moreData;
        if (lines[0] == '\"') {
            parts = lines.Split("\",", 2);
            abilities = parts[0]
                .Trim('"', '[', ']')
                .Split(',')
                .Select(x => x.Trim(' ', '\''))
                .ToList();
        }
        else {
            parts = lines.Split(",", 2);
            abilities = new List<string> {
                parts[0].Trim('[', ']', '\'')
            };
        }
        moreData = parts[1]
            .Split(',')
            .Select(x => string.IsNullOrWhiteSpace(x) ? "0" : x)
            .ToArray();
        
        if (moreData[22].Split().Length > 1) {
            moreData[22] = new Random().Next(30, 255).ToString();
        }
        
        Abilities = abilities;
        AgainstBug = double.Parse(moreData[0]);
        AgainstDark = double.Parse(moreData[1]);
        AgainstDragon = double.Parse(moreData[2]);
        AgainstElectric = double.Parse(moreData[3]);
        AgainstFairy = double.Parse(moreData[4]);
        AgainstFight = double.Parse(moreData[5]);
        AgainstFire = double.Parse(moreData[6]);
        AgainstFlying = double.Parse(moreData[7]);
        AgainstGhost = double.Parse(moreData[8]);
        AgainstGrass = double.Parse(moreData[9]);
        AgainstGround = double.Parse(moreData[10]);
        AgainstIce = double.Parse(moreData[11]);
        AgainstNormal = double.Parse(moreData[12]);
        AgainstPoison = double.Parse(moreData[13]);
        AgainstPsychic = double.Parse(moreData[14]);
        AgainstRock = double.Parse(moreData[15]);
        AgainstSteel = double.Parse(moreData[16]);
        AgainstWater = double.Parse(moreData[17]);
        Attack = int.Parse(moreData[18]);
        BaseEggSteps = int.Parse(moreData[19]);
        BaseHappiness = int.Parse(moreData[20]);
        BaseTotal = int.Parse(moreData[21]);
        CaptureRate = int.Parse(moreData[22]);
        Classfication = moreData[23];
        Defense = int.Parse(moreData[24]);
        ExperienceGrowth = int.Parse(moreData[25]);
        HeightM = double.Parse(moreData[26]);
        Hp = int.Parse(moreData[27]);
        Name = moreData[28];
        PercentageMale =double.Parse(moreData[29]);
        PokedexNumber = int.Parse(moreData[30]);
    }

    public List<string> Abilities { get; set; } 
    public double AgainstBug { get; set; }
    public double AgainstDark { get; set; }
    public double AgainstDragon { get; set; }
    public double AgainstElectric { get; set; }
    public double AgainstFairy { get; set; }
    public double AgainstFight { get; set; }
    public double AgainstFire { get; set; }
    public double AgainstFlying { get; set; }
    public double AgainstGhost { get; set; }
    public double AgainstGrass { get; set; }
    public double AgainstGround { get; set; }
    public double AgainstIce { get; set; }
    public double AgainstNormal { get; set; }
    public double AgainstPoison { get; set; }
    public double AgainstPsychic { get; set; }
    public double AgainstRock { get; set; }
    public double AgainstSteel { get; set; }
    public double AgainstWater { get; set; }
    public int Attack { get; set; }
    public int BaseEggSteps { get; set; }
    public int BaseHappiness { get; set; }
    public int BaseTotal { get; set; }
    public int CaptureRate { get; set; }
    public string Classfication { get; set; } = string.Empty;
    public int Defense { get; set; }
    public int ExperienceGrowth { get; set; }
    public double? HeightM { get; set; }
    public int Hp { get; set; }
    public string Name { get; set; } = string.Empty;
    public double? PercentageMale { get; set; }
    public int PokedexNumber { get; set; }
}