﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getGameHighScores" />
///</summary>
[TlObject(0xe822649d)]
public sealed class RequestGetGameHighScores : IRequest<MyTelegram.Schema.Messages.IHighScores>
{
    public uint ConstructorId => 0xe822649d;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int Id { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser UserId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        bw.Write(Id);
        UserId.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        Id = br.ReadInt32();
        UserId = br.Deserialize<MyTelegram.Schema.IInputUser>();
    }
}