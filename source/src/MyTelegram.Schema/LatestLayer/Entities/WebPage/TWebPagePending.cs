﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A preview of the webpage is currently being generated
/// See <a href="https://corefork.telegram.org/constructor/webPagePending" />
///</summary>
[TlObject(0xb0d13e47)]
public sealed class TWebPagePending : IWebPage
{
    public uint ConstructorId => 0xb0d13e47;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// ID of preview
    ///</summary>
    public long Id { get; set; }
    public string? Url { get; set; }

    ///<summary>
    /// When was the processing started
    ///</summary>
    public int Date { get; set; }

    public void ComputeFlag()
    {
        if (Url != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        if (Flags[0]) { writer.Write(Url); }
        writer.Write(Date);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Id = reader.ReadInt64();
        if (Flags[0]) { Url = reader.ReadString(); }
        Date = reader.ReadInt32();
    }
}