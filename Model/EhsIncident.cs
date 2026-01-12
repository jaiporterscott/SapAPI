using System.Collections.Generic;
using System.Linq;
using Sap.Model.EHSIncident;

namespace Sap.Model;

public class EhsIncident : EhsIncidentEntity
{
    public EhsIncident(EhsIncidentEntity EhsIncident) : base(EhsIncident)
    {
        this.ToAttachments = EhsIncident.ToAttachments != null ? EhsIncident.ToAttachments.Results.Select(s => new EhsAttachmentEntity(s, IncidentID)).ToList() : [];
        this.ToPersons = EhsIncident.ToPersons?.Results != null ? EhsIncident.ToPersons.Results?.Select(s => new EhsIncidentPerson(s, IncidentID, IncidentUUID)).ToList() : [];
        this.ToLocation = EhsIncident.ToLocation ?? this.ToLocation;
    }
    public EhsIncident() : base()
    {

    }
    public new List<EhsAttachmentEntity>? ToAttachments { get; set; } = new List<EhsAttachmentEntity>();
    public new List<EhsIncidentPerson>? ToPersons { get; set; } = new List<EhsIncidentPerson>();
    public new EhsIncidentLocationEntity? ToLocation { get; set; } = new EhsIncidentLocationEntity();


}
