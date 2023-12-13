﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// <a href="https://corefork.telegram.org/api/transcribe">Transcribe voice message</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 403 PREMIUM_ACCOUNT_REQUIRED A premium account is required to execute this action.
/// 400 TRANSCRIPTION_FAILED Audio transcription failed.
/// See <a href="https://corefork.telegram.org/method/messages.transcribeAudio" />
///</summary>
[TlObject(0x269e9a49)]
public sealed class RequestTranscribeAudio : IRequest<MyTelegram.Schema.Messages.ITranscribedAudio>
{
    public uint ConstructorId => 0x269e9a49;
    ///<summary>
    /// Peer ID where the voice message was sent
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Voice message ID
    ///</summary>
    public int MsgId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(MsgId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        MsgId = reader.ReadInt32();
    }
}