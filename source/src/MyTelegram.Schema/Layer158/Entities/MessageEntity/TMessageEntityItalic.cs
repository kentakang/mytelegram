﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageEntityItalic" />
///</summary>
[TlObject(0x826f8b60)]
public sealed class TMessageEntityItalic : IMessageEntity
{
    public uint ConstructorId => 0x826f8b60;
    public int Offset { get; set; }
    public int Length { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Offset);
        bw.Write(Length);
    }

    public void Deserialize(BinaryReader br)
    {
        Offset = br.ReadInt32();
        Length = br.ReadInt32();
    }
}