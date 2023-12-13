﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Top peer category
/// See <a href="https://corefork.telegram.org/constructor/topPeerCategoryPeers" />
///</summary>
[TlObject(0xfb834291)]
public sealed class TTopPeerCategoryPeers : ITopPeerCategoryPeers
{
    public uint ConstructorId => 0xfb834291;
    ///<summary>
    /// Top peer category of peers
    /// See <a href="https://corefork.telegram.org/type/TopPeerCategory" />
    ///</summary>
    public MyTelegram.Schema.ITopPeerCategory Category { get; set; }

    ///<summary>
    /// Count of peers
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// Peers
    ///</summary>
    public TVector<MyTelegram.Schema.ITopPeer> Peers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Category);
        writer.Write(Count);
        writer.Write(Peers);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Category = reader.Read<MyTelegram.Schema.ITopPeerCategory>();
        Count = reader.ReadInt32();
        Peers = reader.Read<TVector<MyTelegram.Schema.ITopPeer>>();
    }
}