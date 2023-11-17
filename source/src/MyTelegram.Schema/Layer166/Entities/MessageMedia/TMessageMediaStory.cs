﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/messageMediaStory" />
///</summary>
[TlObject(0x68cb6283)]
public sealed class TMessageMediaStory : IMessageMedia
{
    public uint ConstructorId => 0x68cb6283;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ViaMention { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/StoryItem" />
    ///</summary>
    public MyTelegram.Schema.IStoryItem? Story { get; set; }

    public void ComputeFlag()
    {
        if (ViaMention) { Flags[1] = true; }
        if (Story != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Id);
        if (Flags[0]) { writer.Write(Story); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { ViaMention = true; }
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        Id = reader.ReadInt32();
        if (Flags[0]) { Story = reader.Read<MyTelegram.Schema.IStoryItem>(); }
    }
}