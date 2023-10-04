﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Invites were enabled/disabled
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionToggleInvites" />
///</summary>
[TlObject(0x1b7907ae)]
public sealed class TChannelAdminLogEventActionToggleInvites : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x1b7907ae;
    ///<summary>
    /// New value
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(NewValue);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        NewValue = reader.Read();
    }
}