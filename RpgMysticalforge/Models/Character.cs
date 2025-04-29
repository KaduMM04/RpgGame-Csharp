namespace RpgMysticalforge.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Level CharacterLevel { get; set; } = new Level();
        public Attributes Attributes { get; set; } = new(); 
        public CourseClass CharacterClass { get; set; }
    }
}