﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0x0a9f2259)]
public sealed class TDestroyAuthKeyNone : IDestroyAuthKeyRes
{
    public uint ConstructorId => 0x0a9f2259;


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