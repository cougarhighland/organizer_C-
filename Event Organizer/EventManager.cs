using System;

public class EventManager
{
    private double costPerPerson;
    private double feePerPerson;
    private ParticipantManager participantManager;
    private string title;

    public double CostPerPerson
    {
        get { return costPerPerson; }
        set { costPerPerson = value; }
    }

    public double FeePerPerson
    {
        get { return feePerPerson; }
        set { feePerPerson = value; }
    }

    public ParticipantManager Participants
    {
        get { return participantManager; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public EventManager()
    {
        participantManager = new ParticipantManager();
    }

    public double CalcTotalCost()
    {
        return costPerPerson * participantManager.Count;
    }

    public double CalcTotalFees()
    {
        return feePerPerson * participantManager.Count;
    }
}
