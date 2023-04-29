﻿namespace MyTelegram.Domain.Events.Poll;

public class PollClosedEvent : AggregateEvent<PollAggregate, PollId>
{
    public PollClosedEvent(Peer toPeer,
        long pollId,
        int closeDate)
    {
        ToPeer = toPeer;
        PollId = pollId;
        CloseDate = closeDate;
    }

    public Peer ToPeer { get; }
    public long PollId { get; }
    public int CloseDate { get; }
}
