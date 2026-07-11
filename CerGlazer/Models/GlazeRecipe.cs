using CerGlazer.Models.Enums;

namespace CerGlazer.Models
{
    public class GlazeRecipe : Glaze
    {      
        public string? Color { get; set; }

        public required List<GlazeMaterial> Ingredients { get; set; }

        public ApplicationMethods PreferredApplicationMethod { get; set; }

        public string? Notes { get; set; }
    }
}
