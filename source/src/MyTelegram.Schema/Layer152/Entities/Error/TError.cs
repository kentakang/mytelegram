﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/error" />
///</summary>
[TlObject(0xc4b9f9bb)]
public sealed class TError : IError
{
    public uint ConstructorId => 0xc4b9f9bb;
    public int Code { get; set; }
    public string Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Code);
        bw.Serialize(Text);
    }

    public void Deserialize(BinaryReader br)
    {
        Code = br.ReadInt32();
        Text = br.Deserialize<string>();
    }
}