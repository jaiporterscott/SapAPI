using System;
using Sap.Model.EHSIncident;

namespace Sap.Model;

public class EhsIncidentPerson : EhsPersonEntity
{
    public int IncidentID { get; set; }

    public EhsIncidentPerson(EhsPersonEntity EhsPersonWrapper) : base(EhsPersonWrapper)
    {

    }

    public EhsIncidentPerson(EhsPersonEntity EhsPersonWrapper, int incidentId, Guid incidentUUID) : base(EhsPersonWrapper)
    {
        IncidentID = incidentId;
        IncidentUUID = incidentUUID;
    }

    public EhsIncidentPerson(EhsIncidentPerson EhsPersonWrapper) : base(EhsPersonWrapper)
    {
        IncidentID = EhsPersonWrapper.IncidentID;
    }

    public EhsIncidentPerson() : base()
    {

    }
}
