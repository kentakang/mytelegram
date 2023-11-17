﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
/// Info about the participants of a group call or livestream
/// See <a href="https://corefork.telegram.org/constructor/phone.groupParticipants" />
///</summary>
[TlObject(0xf47751b6)]
public sealed class TGroupParticipants : IGroupParticipants
{
    public uint ConstructorId => 0xf47751b6;
    ///<summary>
    /// Number of participants
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// List of participants
    ///</summary>
    public TVector<MyTelegram.Schema.IGroupCallParticipant> Participants { get; set; }

    ///<summary>
    /// If not empty, the specified list of participants is partial, and more participants can be fetched specifying this parameter as <code>offset</code> in <a href="https://corefork.telegram.org/method/phone.getGroupParticipants">phone.getGroupParticipants</a>.
    ///</summary>
    public string NextOffset { get; set; }

    ///<summary>
    /// Mentioned chats
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Mentioned users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    ///<summary>
    /// Version info
    ///</summary>
    public int Version { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Count);
        writer.Write(Participants);
        writer.Write(NextOffset);
        writer.Write(Chats);
        writer.Write(Users);
        writer.Write(Version);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Count = reader.ReadInt32();
        Participants = reader.Read<TVector<MyTelegram.Schema.IGroupCallParticipant>>();
        NextOffset = reader.ReadString();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
        Version = reader.ReadInt32();
    }
}