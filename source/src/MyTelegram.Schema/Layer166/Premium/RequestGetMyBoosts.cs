﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Premium;

///<summary>
/// See <a href="https://corefork.telegram.org/method/premium.getMyBoosts" />
///</summary>
[TlObject(0xbe77b4a)]
public sealed class RequestGetMyBoosts : IRequest<MyTelegram.Schema.Premium.IMyBoosts>
{
    public uint ConstructorId => 0xbe77b4a;

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