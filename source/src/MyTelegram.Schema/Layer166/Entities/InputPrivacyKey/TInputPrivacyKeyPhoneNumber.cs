﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Whether people will be able to see your phone number
/// See <a href="https://corefork.telegram.org/constructor/inputPrivacyKeyPhoneNumber" />
///</summary>
[TlObject(0x352dafa)]
public sealed class TInputPrivacyKeyPhoneNumber : IInputPrivacyKey
{
    public uint ConstructorId => 0x352dafa;


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