using System.Globalization;
using System.Reflection;

namespace Pokemon;

public class Program {
    public static void Main(string[] args) {
        List<PokemonEggyszeru> PE =
            File.ReadAllLines("../../../Files/pokemon.csv")
                .Skip(1)
                .Select(x => new PokemonEggyszeru(x))
                .ToList();

        List<PokemonOsszetett> PO = File.ReadAllLines("../../../Files/pokemon2.csv")
            .Skip(1)
            .Select(x => new PokemonOsszetett(x))
            .ToList();

        // 3 feladat

        // List<Pokemon> p = PE.Join(PO,
        //     pe => pe.PokedexNumber,
        //     po => po.PokedexNumber,
        //     (pe, po) => new Pokemon(pe, po)
        // ).ToList();

        List<Pokemon> Pokemons = PE.Zip(PO, (pe, po) => new Pokemon(pe, po)).ToList();

        // 4 feladat

        Console.WriteLine(Pokemons.First(x => x.hp == Pokemons.Max(p => p.hp)).name);
        // Console.WriteLine(Pokemons
        //     .OrderByDescending(x => x.hp)
        //     .First());
        // Console.WriteLine(Pokemons.MaxBy(x => x.hp));

        // 5 feladat
        List<Pokemon> poison = Pokemons
            .Where(x => x.type1 == "poison" || x.type2 == "poison").ToList();
        Console.WriteLine(string.Join(", ", poison.Select(x => x.name)));


        // 6 feladat

        Console.WriteLine(poison.First(x => x.hp == poison.Min(p => p.hp)).name);
        Console.WriteLine();

        // 7 feladat
        Console.WriteLine(string.Join("\n", PE
            .Where(pe => pe.Speed > 100)
            .OrderByDescending(pe => pe.Speed)
            .Select(pe => $"{Pokemons.First(p => p.pokedex_number == pe.PokedexNumber).name}," +
                          $" {Pokemons.First(p => p.pokedex_number == pe.PokedexNumber).classfication}," +
                          $" {pe.Speed}")
        ));

        Console.WriteLine();
        // 8 feladat

        IEnumerable<IGrouping<string, Pokemon>> ClassPokemons = Pokemons
            .Where(x => !string.IsNullOrEmpty(x.classfication))
            .GroupBy(x => x.classfication);
        
        Console.WriteLine(string.Join("\n", ClassPokemons.Select(x => $"{x.Key}: {x.Count()} db")));
        
        Console.WriteLine();
        
        // 9 feladat
        Console.WriteLine(PE.Join(Pokemons, pe => pe.PokedexNumber, p => p.pokedex_number,
                (pe, p) => new { pe, p }).Where(x => x.p.classfication == "Dragon Pokemon")
            .GroupBy(_ => true)
            .Select(g => $"Attack: {g.Average(x => x.pe.SpAttack)}, Defense: {g.Average(x => x.pe.SpDefense)}")
            .First());
    }
}