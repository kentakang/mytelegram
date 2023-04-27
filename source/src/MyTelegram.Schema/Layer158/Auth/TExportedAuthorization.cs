﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;


///<summary>
///See <a href="https://core.telegram.org/constructor/auth.exportedAuthorization" />
///</summary>
[TlObject(0xb434e2b8)]
public sealed class TExportedAuthorization : IExportedAuthorization
{
    public uint ConstructorId => 0xb434e2b8;
    public long Id { get; set; }
    public byte[] Bytes { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Id);
        bw.Serialize(Bytes);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.ReadInt64();
        Bytes = br.Deserialize<byte[]>();
    }
}