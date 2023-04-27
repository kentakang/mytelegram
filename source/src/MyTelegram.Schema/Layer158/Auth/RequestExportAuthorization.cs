﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
///See <a href="https://core.telegram.org/method/auth.exportAuthorization" />
///</summary>
[TlObject(0xe5bfffcd)]
public sealed class RequestExportAuthorization : IRequest<MyTelegram.Schema.Auth.IExportedAuthorization>
{
    public uint ConstructorId => 0xe5bfffcd;
    public int DcId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(DcId);
    }

    public void Deserialize(BinaryReader br)
    {
        DcId = br.ReadInt32();
    }
}