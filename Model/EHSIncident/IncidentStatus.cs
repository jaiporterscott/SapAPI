using System.Collections.Generic;

namespace Sap.Model.EHSIncident;

/// <summary>
///
/// </summary>
public class IncidentStatus
{
    public string Id { get; set; }
    public string Name { get; set; }

    public IncidentStatus(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public IncidentStatus()
    {

    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public static List<IncidentStatus> GetStatuses()
    {
        return new List<IncidentStatus>
        {
            new ("00", "Void"),
            new ("01", "New"),
            new ("02", "In Progress"),
            new ("03", "Closed"),
            new ("04", "Reopened")
        };
    }
}
