﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// Obtain info about the view count, forward count, reactions and recent viewers of one or more <a href="https://corefork.telegram.org/api/stories">stories</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/stories.getStoriesViews" />
///</summary>
[TlObject(0x28e16cc8)]
public sealed class RequestGetStoriesViews : IRequest<MyTelegram.Schema.Stories.IStoryViews>
{
    public uint ConstructorId => 0x28e16cc8;
    ///<summary>
    /// Peer whose stories should be fetched
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Story IDs
    ///</summary>
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
