namespace KiApiModels.Classes;

public class KiApplications
{
    public int ID { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ShortDescription { get; set; } = string.Empty;

    public string LongDescription { get; set; } = string.Empty;

    public DateTime ReleaseDate { get; set; }

    public bool Windows { get; set; }

    public bool Mac { get; set; }

    public bool Web { get; set; }

    public bool Android { get; set; }

    public bool IOS { get; set; }

}
