﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Theme
/// See <a href="https://corefork.telegram.org/constructor/inputTheme" />
///</summary>
[TlObject(0x3c5693e9)]
public sealed class TInputTheme : IInputTheme
{
    public uint ConstructorId => 0x3c5693e9;
    ///<summary>
    /// ID
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// Access hash
    ///</summary>
    public long AccessHash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(AccessHash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt64();
        AccessHash = reader.ReadInt64();
    }
}