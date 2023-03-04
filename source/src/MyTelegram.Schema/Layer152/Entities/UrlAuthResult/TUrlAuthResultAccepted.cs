﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/urlAuthResultAccepted" />
///</summary>
[TlObject(0x8f8c0e4e)]
public sealed class TUrlAuthResultAccepted : IUrlAuthResult
{
    public uint ConstructorId => 0x8f8c0e4e;
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
    }
}