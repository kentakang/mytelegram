﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Fetch only recent participants
/// See <a href="https://corefork.telegram.org/constructor/channelParticipantsRecent" />
///</summary>
[TlObject(0xde3f3c79)]
public sealed class TChannelParticipantsRecent : IChannelParticipantsFilter
{
    public uint ConstructorId => 0xde3f3c79;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}