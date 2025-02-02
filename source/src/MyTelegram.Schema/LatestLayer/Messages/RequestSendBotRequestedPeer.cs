﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Send a chosen peer, as requested by a <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestPeer">keyboardButtonRequestPeer</a> button.
/// See <a href="https://corefork.telegram.org/method/messages.sendBotRequestedPeer" />
///</summary>
[TlObject(0xfe38d01b)]
public sealed class RequestSendBotRequestedPeer : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xfe38d01b;
    ///<summary>
    /// The bot that sent the <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestPeer">keyboardButtonRequestPeer</a> button.
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// ID of the message that contained the reply keyboard with the <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestPeer">keyboardButtonRequestPeer</a> button.
    ///</summary>
    public int MsgId { get; set; }

    ///<summary>
    /// The <code>button_id</code> field from the <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestPeer">keyboardButtonRequestPeer</a> constructor.
    ///</summary>
    public int ButtonId { get; set; }

    ///<summary>
    /// The chosen peer.
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer RequestedPeer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(MsgId);
        writer.Write(ButtonId);
        writer.Write(RequestedPeer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        MsgId = reader.ReadInt32();
        ButtonId = reader.ReadInt32();
        RequestedPeer = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}
