namespace TrailNavigator.Core.BusienssModels.DataModels.Trail;

public class TrailEntity
{
    public int TrailId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Difficulty { get; set; }
    public string Length { get; set; }
    public string Elevation { get; set; }
    public string Status { get; set; }
    public DateTime CreateDate { get; set; }
}