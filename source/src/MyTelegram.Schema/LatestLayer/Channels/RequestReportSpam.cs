﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 INPUT_USER_DEACTIVATED The specified user was deleted.
/// 400 USER_ID_INVALID The provided user ID is invalid.
/// See <a href="https://corefork.telegram.org/method/channels.reportSpam" />
///</summary>
[TlObject(0xf44a8315)]
public sealed class RequestReportSpam : IRequest<IBool>
{
    public uint ConstructorId => 0xf44a8315;
    ///<summary>
    /// Supergroup
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// Participant whose messages should be reported
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Participant { get; set; }

    ///<summary>
    /// IDs of spam messages
    ///</summary>
    public TVector<int> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
        writer.Write(Participant);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        Participant = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.Read<TVector<int>>();
    }
}
