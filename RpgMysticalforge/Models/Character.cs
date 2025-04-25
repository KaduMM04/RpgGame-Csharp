namespace RpgMysticalforge.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level CharacterLevel { get; set; } = new Level();
        public CourseClass CharacterClass { get; set; }
    }
}