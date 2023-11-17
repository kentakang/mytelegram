﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Change the chat theme of a certain chat
/// <para>Possible errors</para>
/// Code Type Description
/// 400 EMOJI_INVALID The specified theme emoji is valid.
/// 400 EMOJI_NOT_MODIFIED The theme wasn't changed.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.setChatTheme" />
///</summary>
[TlObject(0xe63be13f)]
public sealed class RequestSetChatTheme : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xe63be13f;
    ///<summary>
    /// Private chat where to change theme
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Emoji, identifying a specific chat theme; a list of chat themes can be fetched using <a href="https://corefork.telegram.org/method/account.getChatThemes">account.getChatThemes</a>
    ///</summary>
    public string Emoticon { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Emoticon);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Emoticon = reader.ReadString();
    }
}