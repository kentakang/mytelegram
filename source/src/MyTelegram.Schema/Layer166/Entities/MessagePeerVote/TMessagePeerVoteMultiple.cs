﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/messagePeerVoteMultiple" />
///</summary>
[TlObject(0x4628f6e6)]
public sealed class TMessagePeerVoteMultiple : IMessagePeerVote
{
    public uint ConstructorId => 0x4628f6e6;
    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<byte[]> Options { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Options);
        writer.Write(Date);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        Options = reader.Read<TVector<byte[]>>();
        Date = reader.ReadInt32();
    }
}