using RpgMysticalforge.Data.Dtos;

namespace RpgMysticalforge.Data.Dtos
{
    public class CharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LevelDTO CharacterLevel { get; set; } = new LevelDTO();
        public AttributesDTO Attributes { get; set; } = new AttributesDTO();
        public string CharacterClassName { get; set; }
    }
}