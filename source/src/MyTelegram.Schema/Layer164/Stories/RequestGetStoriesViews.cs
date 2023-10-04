﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// See <a href="https://corefork.telegram.org/method/stories.getStoriesViews" />
///</summary>
[TlObject(0x28e16cc8)]
public sealed class RequestGetStoriesViews : IRequest<MyTelegram.Schema.Stories.IStoryViews>
{
    public uint ConstructorId => 0x28e16cc8;
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public TVector<int> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.Read<TVector<int>>();
    }
}