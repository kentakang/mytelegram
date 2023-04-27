﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Chatlists;


///<summary>
///See <a href="https://core.telegram.org/constructor/chatlists.chatlistUpdates" />
///</summary>
[TlObject(0x93bd878d)]
public sealed class TChatlistUpdates : IChatlistUpdates
{
    public uint ConstructorId => 0x93bd878d;
    public TVector<MyTelegram.Schema.IPeer> MissingPeers { get; set; }
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        MissingPeers.Serialize(bw);
        Chats.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        MissingPeers = br.Deserialize<TVector<MyTelegram.Schema.IPeer>>();
        Chats = br.Deserialize<TVector<MyTelegram.Schema.IChat>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}