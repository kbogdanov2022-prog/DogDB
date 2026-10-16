using System.ComponentModel.DataAnnotations;

public class Dog
{
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = null!;

    [Range(0, 30)]
    public int Age { get; set; }

    [Required]
    public int BreedId { get; set; }

    public virtual Breed Breed { get; set; } = null!;

    public string Picture { get; set; } = null!;
}
