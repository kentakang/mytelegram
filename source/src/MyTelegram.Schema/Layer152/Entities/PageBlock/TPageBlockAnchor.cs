﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockAnchor" />
///</summary>
[TlObject(0xce0d37b0)]
public sealed class TPageBlockAnchor : IPageBlock
{
    public uint ConstructorId => 0xce0d37b0;
    public string Name { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Name);
    }

    public void Deserialize(BinaryReader br)
    {
        Name = br.Deserialize<string>();
    }
}