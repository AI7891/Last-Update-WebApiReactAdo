namespace Demo_WebAPI_02.DTO
{
    public class PlanetResponsesAllDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
    }
    public class PlanetRequestDto 
    {
        public required string Name { get; set; }
        public required int SolarSystemID { get; set; }
        public required int No_Moon { get; set; }
        
        public required string? Description { get; set; }
        public DateTime DiscoveryPlanetDate { get; set; }
        
        
    }
    public class PlanetResponseDto 
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int SolarSystemID { get; set; }
        public required int No_Moon { get; set; }
        
        public required string? Description { get; set; }
        public DateTime DiscoveryPlanetDate { get; set; }
        
        
    }
}
