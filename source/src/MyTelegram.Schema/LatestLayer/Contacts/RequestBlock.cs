﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
/// Adds the user to the blacklist.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CONTACT_ID_INVALID The provided contact ID is invalid.
/// 400 INPUT_USER_DEACTIVATED The specified user was deleted.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/contacts.block" />
///</summary>
[TlObject(0x2e2e8734)]
public sealed class RequestBlock : IRequest<IBool>
{
    public uint ConstructorId => 0x2e2e8734;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool MyStoriesFrom { get; set; }

    ///<summary>
    /// User ID
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Id { get; set; }

    public void ComputeFlag()
    {
        if (MyStoriesFrom) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { MyStoriesFrom = true; }
        Id = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}
