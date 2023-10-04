﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Empty constructor.
/// See <a href="https://corefork.telegram.org/constructor/inputDocumentEmpty" />
///</summary>
[TlObject(0x72f0eaae)]
public sealed class TInputDocumentEmpty : IInputDocument,IEmpty
{
    public uint ConstructorId => 0x72f0eaae;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}