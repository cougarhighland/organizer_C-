using System;

public class EventManager
{
    private float costPerPerson;
    private float feePerPerson;
    private string title;

    ParticipantManager participantManager = new ParticipantManager();

    public float CostPerPerson
    {
        get { return costPerPerson; }
        set {
            if(value >= 0.0)
            {
                costPerPerson = value;
            }
        }
    }

    public float FeePerPerson
    {
        get { return feePerPerson; }
        set
        {
            if (value >= 0.0)
            {
                feePerPerson = value;
            }
        }
    }

    public ParticipantManager Participants
    {
        get { return participantManager; }
    }

    public string Title
    {
        get { return title; }
        set {
            if(string.IsNullOrEmpty(value))
            {
                title = value;
            }
        }
    }

    public EventManager()
    {
        participantManager = new ParticipantManager();
    }

    public float CalcTotalCost()
    {
        return costPerPerson * participantManager.Count;
    }

    public float CalcTotalFees()
    {
        return feePerPerson * participantManager.Count;
    }
}
