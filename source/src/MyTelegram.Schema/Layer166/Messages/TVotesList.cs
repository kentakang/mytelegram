﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// How users voted in a poll
/// See <a href="https://corefork.telegram.org/constructor/messages.votesList" />
///</summary>
[TlObject(0x4899484e)]
public sealed class TVotesList : IVotesList
{
    public uint ConstructorId => 0x4899484e;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Total number of votes for all options (or only for the chosen <code>option</code>, if provided to <a href="https://corefork.telegram.org/method/messages.getPollVotes">messages.getPollVotes</a>)
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// Vote info for each user
    ///</summary>
    public TVector<MyTelegram.Schema.IMessagePeerVote> Votes { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Info about users that voted in the poll
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    ///<summary>
    /// Offset to use with the next <a href="https://corefork.telegram.org/method/messages.getPollVotes">messages.getPollVotes</a> request, empty string if no more results are available.
    ///</summary>
    public string? NextOffset { get; set; }

    public void ComputeFlag()
    {
        if (NextOffset != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Count);
        writer.Write(Votes);
        writer.Write(Chats);
        writer.Write(Users);
        if (Flags[0]) { writer.Write(NextOffset); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Count = reader.ReadInt32();
        Votes = reader.Read<TVector<MyTelegram.Schema.IMessagePeerVote>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
        if (Flags[0]) { NextOffset = reader.ReadString(); }
    }
}