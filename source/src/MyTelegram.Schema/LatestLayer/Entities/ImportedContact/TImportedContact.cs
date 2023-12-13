﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Successfully imported contact.
/// See <a href="https://corefork.telegram.org/constructor/importedContact" />
///</summary>
[TlObject(0xc13e3c50)]
public sealed class TImportedContact : IImportedContact
{
    public uint ConstructorId => 0xc13e3c50;
    ///<summary>
    /// User identifier
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// The contact's client identifier (passed to one of the <a href="https://corefork.telegram.org/type/InputContact">InputContact</a> constructors)
    ///</summary>
    public long ClientId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(ClientId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.ReadInt64();
        ClientId = reader.ReadInt64();
    }
}