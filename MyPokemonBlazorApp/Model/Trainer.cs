using System.ComponentModel.DataAnnotations;

namespace MyPokemonBlazorApp.Model
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Pokemon Companion { get; set; }
    }
}
