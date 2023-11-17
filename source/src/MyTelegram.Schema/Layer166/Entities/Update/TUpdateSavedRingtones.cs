﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The list of saved notification sounds has changed, use <a href="https://corefork.telegram.org/method/account.getSavedRingtones">account.getSavedRingtones</a> to fetch the new list.
/// See <a href="https://corefork.telegram.org/constructor/updateSavedRingtones" />
///</summary>
[TlObject(0x74d8be99)]
public sealed class TUpdateSavedRingtones : IUpdate
{
    public uint ConstructorId => 0x74d8be99;


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