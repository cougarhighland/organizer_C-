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
        if (participantIn == null)
        {
            return false;
        }
        participants.Add(participantIn);
        return true;
    }

    public bool AddParticipant(string firstName, string lastName, Address addressIn)
    {
        Participant newParticipant = new Participant
        {
            FirstName = firstName,
            LastName = lastName,
            Address = addressIn
        };
        participants.Add(newParticipant);
        return true;
    }

    public bool ChangeParticipantAt(Participant participantIn, int index)
    {
        bool ok = true;

        if (CheckIndex(index) && participantIn != null)
        {
            participants[index] = participantIn;
        }else
        {
            ok = false;
        }
        return ok;
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
        }
        else
        {
            return false ;
        }
        return true;
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
        string[] infoStrArr = new string[participants.Count];
        int i = 0;
        foreach (Participant participantObject in participants)
        {
            infoStrArr[i] = participantObject.ToString();
            i++;
        }
        return infoStrArr;
    }

    public void TestValues()
    {
        // You can add test values here to check your methods
    }
}
