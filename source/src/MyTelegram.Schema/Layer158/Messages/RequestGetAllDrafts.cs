﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getAllDrafts" />
///</summary>
[TlObject(0x6a3f8d65)]
public sealed class RequestGetAllDrafts : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x6a3f8d65;

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}