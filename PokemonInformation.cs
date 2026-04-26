using System;
using PokeAPI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTestAPI
{
    /// <summary>
    /// Class for finding information and storing it in an array
    /// </summary>
    public class PokemonInformation
    {
        /// <summary>
        /// Does the API search and puts the info needed for the form into an array.
        /// </summary>
        /// <param name="pokemonName">Pokemon Name entered by user</param>
        /// <returns>Array of data of Pokemon</returns>
        public async Task<string[]> PokemonLookup(string pokemonName)
        {
            var pokemonData = await DataFetcher.GetNamedApiObject<PokemonSpecies>(pokemonName.ToLower());
            string[] pokemonSpecies = new string[7];
            pokemonSpecies[0] = pokemonData.Name;
            pokemonSpecies[1] = pokemonData.BaseHappiness.ToString();
            pokemonSpecies[2] = pokemonData.CaptureRate.ToString();
            pokemonSpecies[3] = pokemonData.Habitat?.Name ?? "None";
            pokemonSpecies[4] = pokemonData.GrowthRate?.Name ?? "Unkown";

            var flavorText = pokemonData.FlavorTexts.FirstOrDefault(f => f.Language.Name == "en");
            pokemonSpecies[5] = flavorText.FlavorText;
            
            pokemonSpecies[6] = pokemonData.EggGroups?.FirstOrDefault().Name ?? "None";
            return pokemonSpecies;
        }
    }
}
