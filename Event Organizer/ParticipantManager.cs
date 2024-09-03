using System;

public class ParticipantManager
{
	private List<Participant> participants;

	public ParticipantManager()
	{
        participants = new List<Participant>();
	}

    public int Count
    {
        get { return participants.Count; }
    }

    public bool AddParticipant(Participant participantIn)
    {
        participants.Add(participantIn);
        return true; // Assuming always successful for simplicity
    }

    public bool AddParticipant(string firstName, string lastName, Address addressIn)
    {
        Participant newParticipant = new Participant
        {
            FirstName = firstName,
            LastName = lastName,
            Address = addressIn
        };
        return AddParticipant(newParticipant);
    }

    public bool ChangeParticipantAt(Participant participantIn, int index)
    {
        if (CheckIndex(index))
        {
            participants[index] = participantIn;
            return true;
        }
        return false;
    }

    private bool CheckIndex(int index)
    {
        return index >= 0 && index < participants.Count;
    }

    public bool DeleteParticipantAt(int index)
    {
        if (CheckIndex(index))
        {
            participants.RemoveAt(index);
            return true;
        }
        return false;
    }

    public Participant GetParticipantAt(int index)
    {
        if (CheckIndex(index))
        {
            return participants[index];
        }
        return null; // Or throw an exception
    }

    public string[] GetParticipantsInfo()
    {
        string[] infoArray = new string[participants.Count];
        for (int i = 0; i < participants.Count; i++)
        {
            Participant participant = participants[i];
            infoArray[i] = $"{participant.FirstName} {participant.LastName}, {participant.Address.Street}, {participant.Address.City}"; // Modify this as per your requirement
        }
        return infoArray;
    }

    public void TestValues()
    {
        // You can add test values here to check your methods
    }
}
