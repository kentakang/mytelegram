﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Recent t.me link to a chat
/// See <a href="https://corefork.telegram.org/constructor/recentMeUrlChat" />
///</summary>
[TlObject(0xb2da71d2)]
public sealed class TRecentMeUrlChat : IRecentMeUrl
{
    public uint ConstructorId => 0xb2da71d2;
    ///<summary>
    /// t.me URL
    ///</summary>
    public string Url { get; set; }

    ///<summary>
    /// Chat ID
    ///</summary>
    public long ChatId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Url);
        writer.Write(ChatId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Url = reader.ReadString();
        ChatId = reader.ReadInt64();
    }
}