﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updatePeerSettings" />
///</summary>
[TlObject(0x6a7e7366)]
public sealed class TUpdatePeerSettings : IUpdate
{
    public uint ConstructorId => 0x6a7e7366;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PeerSettings" />
    ///</summary>
    public MyTelegram.Schema.IPeerSettings Settings { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        Settings.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
        Settings = br.Deserialize<MyTelegram.Schema.IPeerSettings>();
    }
}