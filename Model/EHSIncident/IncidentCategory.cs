using System.Collections.Generic;

namespace Sap.Model.EHSIncident;

/// <summary>
///
/// </summary>
public class IncidentCategory
{
    public string Id { get; set; }
    public string Name { get; set; }

    public IncidentCategory(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public IncidentCategory()
    {

    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public static List<IncidentCategory> GetStatuses()
    {
        return new List<IncidentCategory>
        {
            new ("001", "EhsIncident"),
            new ("002", "Near Miss"),
            new ("003", "Safety Observation"),
        };
    }
}
