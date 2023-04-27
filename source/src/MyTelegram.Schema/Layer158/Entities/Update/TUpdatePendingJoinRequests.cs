﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updatePendingJoinRequests" />
///</summary>
[TlObject(0x7063c3db)]
public sealed class TUpdatePendingJoinRequests : IUpdate
{
    public uint ConstructorId => 0x7063c3db;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }
    public int RequestsPending { get; set; }
    public TVector<long> RecentRequesters { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        bw.Write(RequestsPending);
        RecentRequesters.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
        RequestsPending = br.ReadInt32();
        RecentRequesters = br.Deserialize<TVector<long>>();
    }
}