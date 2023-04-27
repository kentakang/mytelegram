﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputChatlistDialogFilter" />
///</summary>
[TlObject(0xf3e0da33)]
public sealed class TInputChatlistDialogFilter : IInputChatlist
{
    public uint ConstructorId => 0xf3e0da33;
    public int FilterId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(FilterId);
    }

    public void Deserialize(BinaryReader br)
    {
        FilterId = br.ReadInt32();
    }
}