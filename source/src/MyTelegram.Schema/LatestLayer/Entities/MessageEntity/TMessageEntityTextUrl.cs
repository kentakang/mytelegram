﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Message entity representing a <a href="https://google.com/">text url</a>: for in-text urls like <a href="https://google.com/">https://google.com</a> use <a href="https://corefork.telegram.org/constructor/messageEntityUrl">messageEntityUrl</a>.Note that an additional confirmation popup with the full URL must be displayed to the user before opening this link, unless the domain satisfies the conditions specified in the <a href="https://corefork.telegram.org/api/config#whitelisted-domains">domain whitelist documentation »</a>.
/// See <a href="https://corefork.telegram.org/constructor/messageEntityTextUrl" />
///</summary>
[TlObject(0x76a6d327)]
public sealed class TMessageEntityTextUrl : IMessageEntity
{
    public uint ConstructorId => 0x76a6d327;
    ///<summary>
    /// Offset of message entity within message (in <a href="https://corefork.telegram.org/api/entities#entity-length">UTF-16 code units</a>)
    ///</summary>
    public int Offset { get; set; }

    ///<summary>
    /// Length of message entity within message (in <a href="https://corefork.telegram.org/api/entities#entity-length">UTF-16 code units</a>)
    ///</summary>
    public int Length { get; set; }

    ///<summary>
    /// The actual URL
    ///</summary>
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Offset);
        writer.Write(Length);
        writer.Write(Url);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Offset = reader.ReadInt32();
        Length = reader.ReadInt32();
        Url = reader.ReadString();
    }
}