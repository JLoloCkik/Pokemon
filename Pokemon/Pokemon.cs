namespace Pokemon;

public class Pokemon {
    public int pokedex_number { get; set; }
    public string name { get; set; }
    public int hp { get; set; }
    public int generation { get; set; }
    public string type1 { get; set; }
    public string type2 { get; set; }
    public string classfication { get; set; }
    
    public Pokemon(PokemonEggyszeru pe, PokemonOsszetett po) {
        pokedex_number = pe.PokedexNumber;
        name = po.Name;
        hp = po.Hp;
        generation = pe.Generation;
        type1 = pe.Type1;
        type2 = pe.Type2;
        classfication = po.Classfication;
    }

}