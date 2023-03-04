﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateChatUserTyping" />
///</summary>
[TlObject(0x83487af0)]
public sealed class TUpdateChatUserTyping : IUpdate
{
    public uint ConstructorId => 0x83487af0;
    public long ChatId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer FromId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SendMessageAction" />
    ///</summary>
    public MyTelegram.Schema.ISendMessageAction Action { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(ChatId);
        FromId.Serialize(bw);
        Action.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        ChatId = br.ReadInt64();
        FromId = br.Deserialize<MyTelegram.Schema.IPeer>();
        Action = br.Deserialize<MyTelegram.Schema.ISendMessageAction>();
    }
}