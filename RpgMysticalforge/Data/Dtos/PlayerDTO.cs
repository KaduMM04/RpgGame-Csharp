using RpgMysticalforge.Data.Dtos;

namespace RpgMysticalforge.Data.Dtos
{
    public class PlayerDTO
    {
         public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public List<CharacterDTO> Characters { get; set; } = new List<CharacterDTO>();
    }
}