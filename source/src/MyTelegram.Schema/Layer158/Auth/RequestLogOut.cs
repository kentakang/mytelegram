﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
///See <a href="https://core.telegram.org/method/auth.logOut" />
///</summary>
[TlObject(0x3e72ba19)]
public sealed class RequestLogOut : IRequest<MyTelegram.Schema.Auth.ILoggedOut>
{
    public uint ConstructorId => 0x3e72ba19;

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