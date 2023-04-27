﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Bots;

///<summary>
///See <a href="https://core.telegram.org/method/bots.setBotGroupDefaultAdminRights" />
///</summary>
[TlObject(0x925ec9ea)]
public sealed class RequestSetBotGroupDefaultAdminRights : IRequest<IBool>
{
    public uint ConstructorId => 0x925ec9ea;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatAdminRights" />
    ///</summary>
    public MyTelegram.Schema.IChatAdminRights AdminRights { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        AdminRights.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        AdminRights = br.Deserialize<MyTelegram.Schema.IChatAdminRights>();
    }
}