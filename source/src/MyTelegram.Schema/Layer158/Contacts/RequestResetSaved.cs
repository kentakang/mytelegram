﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
///See <a href="https://core.telegram.org/method/contacts.resetSaved" />
///</summary>
[TlObject(0x879537f1)]
public sealed class RequestResetSaved : IRequest<IBool>
{
    public uint ConstructorId => 0x879537f1;

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