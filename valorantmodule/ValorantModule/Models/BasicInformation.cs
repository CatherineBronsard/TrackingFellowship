namespace ValorantModule.Models
{
    public class BasicInformation
    {
        public string version { get; set; }
        public List<ContentItemDto> characters { get; set; }
        public List<ContentItemDto> maps { get; set; }
        public List<ContentItemDto> chromas { get; set; }
        public List<ContentItemDto> skins { get; set; }
        public List<ContentItemDto> skinLevels { get; set; }
        public List<ContentItemDto> equips { get; set; }
        public List<ContentItemDto> gameModes { get; set; }
        public List<ContentItemDto> sprays { get; set; }
        public List<ContentItemDto> sprayLevels { get; set; }
        public List<ContentItemDto> charms { get; set; }
        public List<ContentItemDto> charmLevels { get; set; }
        public List<ContentItemDto> playerCards { get; set; }
        public List<ContentItemDto> playerTitles { get; set; }
        public List<ActDto> acts { get; set; }
    }
}
