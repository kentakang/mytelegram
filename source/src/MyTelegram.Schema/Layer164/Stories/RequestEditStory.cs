﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// See <a href="https://corefork.telegram.org/method/stories.editStory" />
///</summary>
[TlObject(0xb583ba46)]
public sealed class RequestEditStory : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xb583ba46;
    public BitArray Flags { get; set; } = new BitArray(32);
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int Id { get; set; }
    public MyTelegram.Schema.IInputMedia? Media { get; set; }
    public TVector<MyTelegram.Schema.IMediaArea>? MediaAreas { get; set; }
    public string? Caption { get; set; }
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }
    public TVector<MyTelegram.Schema.IInputPrivacyRule>? PrivacyRules { get; set; }

    public void ComputeFlag()
    {
        if (Media != null) { Flags[0] = true; }
        if (MediaAreas?.Count > 0) { Flags[3] = true; }
        if (Caption != null) { Flags[1] = true; }
        if (Entities?.Count > 0) { Flags[1] = true; }
        if (PrivacyRules?.Count > 0) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Id);
        if (Flags[0]) { writer.Write(Media); }
        if (Flags[3]) { writer.Write(MediaAreas); }
        if (Flags[1]) { writer.Write(Caption); }
        if (Flags[1]) { writer.Write(Entities); }
        if (Flags[2]) { writer.Write(PrivacyRules); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.ReadInt32();
        if (Flags[0]) { Media = reader.Read<MyTelegram.Schema.IInputMedia>(); }
        if (Flags[3]) { MediaAreas = reader.Read<TVector<MyTelegram.Schema.IMediaArea>>(); }
        if (Flags[1]) { Caption = reader.ReadString(); }
        if (Flags[1]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[2]) { PrivacyRules = reader.Read<TVector<MyTelegram.Schema.IInputPrivacyRule>>(); }
    }
}