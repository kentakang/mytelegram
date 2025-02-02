﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/inputMediaWebPage" />
///</summary>
[TlObject(0xc21b8849)]
public sealed class TInputMediaWebPage : IInputMedia
{
    public uint ConstructorId => 0xc21b8849;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool ForceLargeMedia { get; set; }
    public bool ForceSmallMedia { get; set; }
    public bool Optional { get; set; }
    public string Url { get; set; }

    public void ComputeFlag()
    {
        if (ForceLargeMedia) { Flags[0] = true; }
        if (ForceSmallMedia) { Flags[1] = true; }
        if (Optional) { Flags[2] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Url);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { ForceLargeMedia = true; }
        if (Flags[1]) { ForceSmallMedia = true; }
        if (Flags[2]) { Optional = true; }
        Url = reader.ReadString();
    }
}