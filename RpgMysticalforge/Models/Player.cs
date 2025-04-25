namespace RpgMysticalforge.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? NickName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}