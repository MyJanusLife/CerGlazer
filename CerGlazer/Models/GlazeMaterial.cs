namespace CerGlazer.Models
{
    /// <summary>
    /// Ingredient used in a glaze recipe, including its name, amount, and optional notes.
    /// </summary>
    public class GlazeMaterial
    {
        /// <summary>
        /// Name of the glaze material (ingredient).
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// amount of the glaze material used in the recipe, typically measured in grams or other units. 
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Notes or additional information about the glaze material, which can be null if not provided.
        /// </summary>
        public string? Notes { get; set; }
    }
}
