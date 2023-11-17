﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// JSON string
/// See <a href="https://corefork.telegram.org/constructor/jsonString" />
///</summary>
[TlObject(0xb71e767a)]
public sealed class TJsonString : IJSONValue
{
    public uint ConstructorId => 0xb71e767a;
    ///<summary>
    /// Value
    ///</summary>
    public string Value { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Value);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Value = reader.ReadString();
    }
}