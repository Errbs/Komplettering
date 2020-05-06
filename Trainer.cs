using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Trainer
    {
        Collection pokemonCollection = new Collection();
        public void PokemonCollection(int i)
        {
            pokemonCollection.PokemonCollection(i);
        }
        public void ThrowPokemon(int i, Pokemon pokemon)
        {
            pokemonCollection.ThrowPokemon(i, this, pokemon);
            
            
        }
        public void SetPokemonIndex(Pokemon pokemon)
        {
            pokemonCollection.SetPokemonIndex(pokemon);
        }
        public void AddPokemonToCollection(Pokemon pokemon)
        {
            pokemonCollection.AddPokemons(pokemon);
        }
    }
}
