﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
///See <a href="https://core.telegram.org/method/contacts.getContacts" />
///</summary>
[TlObject(0x5dd69e12)]
public sealed class RequestGetContacts : IRequest<MyTelegram.Schema.Contacts.IContacts>
{
    public uint ConstructorId => 0x5dd69e12;
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.ReadInt64();
    }
}